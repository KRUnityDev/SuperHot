using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed = 5f;


    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, cameraSpeed * Time.deltaTime * Vector2.Distance(transform.position, target.position));
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
