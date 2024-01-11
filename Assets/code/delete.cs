using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public float DestroyTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
