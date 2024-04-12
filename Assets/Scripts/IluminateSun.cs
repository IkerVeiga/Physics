using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IluminateSun : MonoBehaviour
{
    private GameObject night;
    // Start is called before the first frame update
    void Start()
    {
        night = GameObject.Find("Night");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            this.gameObject.SetActive(true);
            night.SetActive(false);
        } else
        {
            this.gameObject.SetActive(false);
            night.SetActive(true); 
        }
    }
}
