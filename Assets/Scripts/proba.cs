using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proba : MonoBehaviour
{
    public Transform gracz;
    public float speed=1;
    

    void Start()
    {
    }

    private void FixedUpdate()
    {

    }

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, gracz.position, Time.deltaTime *speed* moving.myTimeScale);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position=transform.parent.transform.position;
            enabled = false;
        }
    }

}
