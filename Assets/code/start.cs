using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 在这里可以调用结束游戏的方法，比如 Quit() 或者加载结束场景
            Application.Quit(); // 或者 SceneManager.LoadScene(gameOverSceneName);
        }
    }

    public void PlayGame() 
    {
        SceneManager.LoadScene(1);   
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
    
}
