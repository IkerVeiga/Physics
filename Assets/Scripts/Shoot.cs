using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject cannon;
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            GameObject bulletInstance = Instantiate(bullet, cannon.transform.position, Quaternion.Euler(0, 0, 0));
            bulletInstance.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 1f * force));
        }
    }


}
