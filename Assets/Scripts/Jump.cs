using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody physics;
    public int jumpForce;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        physics = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jumping();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

    private void Jumping()
    { 

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            physics.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
