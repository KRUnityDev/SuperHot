using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10;
    Vector3 kierunek;

    void Start()
    {
        kierunek =Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Debug.Log(transform.position);
        kierunek = kierunek.normalized;
        Debug.Log(kierunek);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += kierunek * Time.deltaTime * moving.myTimeScale * speed;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    StartCoroutine(Wait(0.5f));
    //    Destroy(this);
    //}

    //IEnumerator Wait(float time)
    //{
    //    yield return new WaitForSeconds(time);
    //}
}
