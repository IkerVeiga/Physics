using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IluminateEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] enemyLights;
    void Start()
    {
        enemyLights = GameObject.FindGameObjectsWithTag("EnemyLight");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I))
        {
            foreach(GameObject gO in enemyLights)
            {
                gO.SetActive(true);
            }
        } else
        {
            foreach (GameObject gO in enemyLights)
            {
                gO.SetActive(false);
            }
        }
    }
}
