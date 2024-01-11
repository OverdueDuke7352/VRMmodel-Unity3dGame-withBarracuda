using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hair : MonoBehaviour
{
    [SerializeField] private Hp hp;
    [SerializeField] private gamemange gamemange;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.O)) // 你可以使用不同的按鍵觸發重新開始
        {
            gamemange.Addscore();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("add"))
        {
            gamemange.Addscore();
        }
        else if (other.CompareTag("lose"))
        {
           hp.Damage();
        }
    }
}
