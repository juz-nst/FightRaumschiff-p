using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steurerung1 : MonoBehaviour
{

    public float speed = 5;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), ForceMode2D.Force);
    }
}
