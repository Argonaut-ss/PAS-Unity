using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * force * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * force * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * force * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * force * Time.deltaTime;
        }
    }
}
