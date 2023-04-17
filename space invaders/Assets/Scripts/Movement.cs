using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //will run this code every 0.02 seconds
    void FixedUpdate()
    {
        //Checks Input from A,D and horizontal keys to see if pressed
        if (Input.GetAxis("Horizontal") != 0)
        {
            rb.MovePosition(new(transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0));
        }
    }

}
