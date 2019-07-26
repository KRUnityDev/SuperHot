using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armata : MonoBehaviour
{
    public float czas_strzelania = 3f;
    Transform gracz;
    public GameObject enemies;

    int indeks=0;
    float timer=0;
    void Start()
    {
        gracz = GameObject.Find("postac").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime*moving.myTimeScale;
        if (timer < 0)
        {
            shoot(indeks);
            indeks++;
        }
        if (indeks >= transform.childCount) indeks = 0;
        
    }

    void shoot(int i)
    {
        timer = czas_strzelania;
        Instantiate(enemies,transform.position, Quaternion.identity,null);
        
    }
}
