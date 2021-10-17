using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;
    int m_score;
    int m_life;
    bool m_isGameover;
    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        this.m_score = 0;
        this.m_life = 3;
        this.m_spawnTime = 0;
        this.m_ui = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.m_spawnTime -= Time.deltaTime;
        if (this.m_isGameover)
        {
            this.m_spawnTime = 0;
            this.m_ui.ShowGameoverPanel(true);
            this.m_score = 0;
            this.m_life = 3;
            return;
        }
        if (this.m_spawnTime <= 0)
        {
            SpawnBall();
            this.m_spawnTime = spawnTime;
        }
    }

    public void SetScore(int score)
    {
        this.m_score = score;
    }

    public int GetScore()
    {
        return this.m_score;
    }

    public void SetLife(int life)
    {
        this.m_life = life;
    }

    public int GetLife()
    {
        return this.m_life;
    }

    public bool GetIsGameOver()
    {
        return m_isGameover;
    }

    public void SetIsGameOver(bool state)
    {
        this.m_isGameover = state;
    }

    public void IncrementScore()
    {
        this.m_score += 1;
        m_ui.SetScoreText("Your score: " + this.m_score);
    }

    public void DecrementLife()
    {
        this.m_life -= 1;
        m_ui.SetLifeText("Life: " + this.m_life);
    }

    public void SpawnBall()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-11, 14), 11);
        if (this.ball)
        {
            Instantiate(ball, spawnPosition, Quaternion.identity);
        }
    }

    public void Replay()
    {
        this.m_score = 0;
        this.m_life = 3;
        this.m_isGameover = false;
        m_ui.SetScoreText("Your score: 0");
        m_ui.SetLifeText("Life: 3");
        m_ui.ShowGameoverPanel(false);
    }
}
