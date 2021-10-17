using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gamecontroller;

    private void Start()
    {
        this.m_gamecontroller = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.m_gamecontroller.IncrementScore();
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            m_gamecontroller.DecrementLife();
            if (m_gamecontroller.GetLife() == 0)
            {
                this.m_gamecontroller.SetIsGameOver(true);
            }
            Destroy(gameObject);
        }
    }
}
