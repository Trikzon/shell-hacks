using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rBody;
    float speedFactor = 20;
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        moveSpeed = horiz * speedFactor;
    }

    void FixedUpdate()
    {
        Vector2 a = new Vector2(moveSpeed, 0.0f);
        rBody.AddForce(a);
    }

}
