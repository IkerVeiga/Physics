using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CrearValla : MonoBehaviour
{
    public GameObject[] spawnable;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnable.Length; i++)
        {
            Instantiate(spawnable[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
