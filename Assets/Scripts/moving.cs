using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed = 10;
    public float jump=10;
    public int jumps=2;

    int jump_index;
    public static float myTimeScale;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jump_index > 0)
            {
                rb.velocity-=new Vector2(0,rb.velocity.y);
                rb.AddForce(new Vector2(0, jump), ForceMode2D.Force);
                jump_index--;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(speed * Time.deltaTime, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-speed * Time.deltaTime, 0), ForceMode2D.Force);
        }
        myTimeScale = rb.velocity.magnitude/10f;
        Debug.Log(myTimeScale);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump_index = jumps;
    }
}
