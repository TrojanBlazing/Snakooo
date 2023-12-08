using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    Rigidbody rb;
    private float h, v;

    
    void Start()
    {
        rb=GetComponent<Rigidbody>();
       
    }

    

    void Update()
    {
        Inputs();
        Move();
    }
    void Inputs()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }
    void Move()
    {
        rb.velocity = new Vector2(rb.velocity.x * h * speed * Time.deltaTime, 0);
        rb.velocity = new Vector2(rb.velocity.x * v* speed * Time.deltaTime, 0);

    }







}
