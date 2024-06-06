using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFoodMiniGame : MonoBehaviour
{
   [SerializeField] GameObject[] prefabFoods;
   [SerializeField] Transform spawnPointMin;
   [SerializeField] Transform spawnPointMax;
    void Start()
    {
        float time = Random.Range(0, 3f);
        Invoke("Generate", time);
    }

   
    void Update()
    {
       
    }

    void Generate(){
        int index = Random.Range(0, prefabFoods.Length-1);
        Instantiate(prefabFoods[index], new Vector3(Random.Range(spawnPointMin.position.x,spawnPointMax.position.x), spawnPointMax.position.y, spawnPointMax.position.z ), Quaternion.identity);
        float time = Random.Range(0, 3f);
        Invoke("Generate", time);
    }
}
