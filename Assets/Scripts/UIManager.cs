using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text lifeText;
    public GameObject gameoverPanel;

    public void SetScoreText(string s)
    {
        if (this.scoreText != null)
        {
            this.scoreText.text = s;
        }
    }

    public void SetLifeText(string s)
    {
        if (this.lifeText != null)
        {
            this.lifeText.text = s;
        }
    }

    public void ShowGameoverPanel(bool isShow)
    {
        if (this.gameoverPanel != null)
        {
            this.gameoverPanel.SetActive(isShow);
        }
    }
}
