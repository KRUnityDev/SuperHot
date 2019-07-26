using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public float speed = 10;
    public float jump=10;
    public int jumps=2;
    public GameObject bullet;

    int jump_index;
    public static float myTimeScale;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W))
        {
            if (jump_index > 0)
            {
                rb.velocity-=new Vector2(0,rb.velocity.y);
                rb.AddForce(new Vector2(0, jump), ForceMode2D.Force);
                jump_index--;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed * Time.deltaTime, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed * Time.deltaTime, 0), ForceMode2D.Force);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shooting();
        }
        myTimeScale = rb.velocity.magnitude/10f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump_index = jumps;
    }

    void shooting()
    {
        Instantiate(bullet, transform.position+new Vector3(0,0.5f,0), Quaternion.identity, null);
    }
}
