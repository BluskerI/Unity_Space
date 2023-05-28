using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruh : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public int speed = 30;

    public float up = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float right = Input.GetAxis("Horizontal");
        if(right != 0) 
        {
            var pos = transform.position;

            pos += Vector3.right * right * Time.deltaTime*speed;

            rigidbody2D.MovePosition(pos);
        }

        float vert = Input.GetAxis("Vertical");
        if (vert != 0)
        {
            var pos = transform.position;

            pos += Vector3.up * vert * Time.deltaTime * speed;

            rigidbody2D.MovePosition(pos);
        }

        //Jump();
    }
     
    //void Jump()
    //{
    //    float vert = Input.GetAxis("Vertical");
    //    if (vert != 0)
    //    {
    //        var pos = transform.position;

    //        pos += Vector3.up * up * Time.deltaTime * speed;

    //        rigidbody2D.MovePosition(pos);
    //    }
    //}
}
