using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp : MonoBehaviour
{
    public int Hps=0;

    public int maxHp = 100;

    public int damage = 20;

    private bool isPaused = false;
    public Image forground = null;
    public float time = 5f;
    [SerializeField] private gamemange gamemange;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject point;
    [SerializeField] private GameObject health;
    


    

    // Start is called before the first frame update
    void Start()
    {
        Hps = maxHp;
        point.SetActive(true);
        health.SetActive(true);
        isPaused = false;
        gameOverMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        forground.fillAmount = (float)Hps / maxHp;
        if (Hps==0) // 你可以使用不同的按鍵觸發暫停
        {
            PauseGame();
        }
        if(isPaused == true)
        {
            endgame();
        }

        if (isPaused && Input.GetKeyDown(KeyCode.R)) // 你可以使用不同的按鍵觸發重新開始
        {
            RestartGame();
        }
        
        if (Input.GetKeyDown(KeyCode.P)) // 你可以使用不同的按鍵觸發重新開始
        {
            Hps -= damage;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 在这里可以调用结束游戏的方法，比如 Quit() 或者加载结束场景
            Application.Quit(); // 或者 SceneManager.LoadScene(gameOverSceneName);
        }
        
        
    }
    public void QuitGame() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        Application.Quit();
    }
    

    public void Damage()
    {
        Hps -= damage;
    }

    public void PauseGame()
    {
        isPaused = true;
        gameOverMenu.SetActive(true);
    }

    void endgame()
    {
        Time.timeScale = 0.0f; // 暫停遊戲時間
    }

    void RestartGame()
    {
        Time.timeScale = 1.0f; // 恢復遊戲時間
        Start();
        gamemange.Start();
    }
            

}
