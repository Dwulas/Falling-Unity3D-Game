using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject goSpawn;
    public float fDifficulty = 40;

    float fSpawn = 0;


    void Start()
    {
        
    }


    void Update()
    {
        fSpawn += fDifficulty * Time.deltaTime;
        fDifficulty += Time.deltaTime * 4f;

        while (fSpawn > 0)
        {
            fSpawn -= 1;
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40 - 20f, 0, Random.value * 40 - 20f);
            Quaternion qRot = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            Vector3 v3Scale = new Vector3(Random.value + 0.1f, 10f, Random.value + 0.1f);
            GameObject goCreate = Instantiate(goSpawn, v3Pos, qRot);
            goCreate.transform.localScale = v3Scale;
        }
    }
}
