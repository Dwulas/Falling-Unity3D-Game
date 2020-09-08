using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject goSpawn;
    public float fDifficulty = 2;
    float fSpawn = 0;


    void Update()
    {
        fSpawn += fDifficulty * Time.deltaTime;
        fDifficulty += Time.deltaTime * 2f;

        while (fSpawn > 0)
        {
            fSpawn -= 1;
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40 - 20f, 0, Random.value * 40 - 20f);
            Quaternion qRot = Quaternion.Euler(0, 0, 0);
            Vector3 v3Scale = new Vector3(1f, 1f, 1f);
            GameObject goCreate = Instantiate(goSpawn, v3Pos, qRot);
            goCreate.transform.localScale = v3Scale;
        }
    }

}
