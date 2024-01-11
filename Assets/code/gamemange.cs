using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemange : MonoBehaviour
{
    public int Score = 0;
    public void Start()
    {
        Score = 0;
        scoreText.text = Score.ToString();
        gameOverscoreText.text = "Calories : " + Score.ToString();
        gameOverBestscoreText.text = "Best : " + Score.ToString();
    }

    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private TMP_Text gameOverscoreText;
    [SerializeField] private TMP_Text gameOverBestscoreText;

    public void Addscore()
    {
        Score++;
        scoreText.text = Score.ToString();
        gameOverscoreText.text = "Calories : " + Score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore",0);

        if(Score > bestScore)
        {
            bestScore = Score;
            PlayerPrefs.SetInt("BestScore",bestScore);
        }
        
        gameOverBestscoreText.text = "Best : " + bestScore.ToString();
        StartCoroutine(WaitForOneSecond());
        
    }

    public void zero()
    {
        Score=0;
    }

    IEnumerator WaitForOneSecond()
    {
        yield return new WaitForSeconds(1f);
    }
    
}
