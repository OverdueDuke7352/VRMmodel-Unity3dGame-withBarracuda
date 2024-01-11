using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private gamemange gamemange;
    public Transform[] SpawnPoints;
    public float SpawnTime = 2.5f;
    public GameObject[] Items;
    public float time = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitLoad());        
        InvokeRepeating("SpawnItems", SpawnTime, SpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnItems()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int ItemIndex = Random.Range(0, Items.Length);
        Instantiate(Items[ItemIndex], SpawnPoints[spawnIndex].position, Quaternion.identity);
    }
    private IEnumerator WaitLoad()
    {
        yield return new WaitForSeconds(time);
    }
}
