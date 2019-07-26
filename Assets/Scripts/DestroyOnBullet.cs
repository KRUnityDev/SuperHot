using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBullet : MonoBehaviour
{
    public Explodable explodable;
    public float hitForceMultiplier = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("bullet"))
        {
            Debug.Log("explode!!");
            explodable.explode(collision.transform.position, collision.relativeVelocity.magnitude * hitForceMultiplier);
        }
    }
}
