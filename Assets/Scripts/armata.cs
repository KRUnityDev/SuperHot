using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armata : MonoBehaviour
{
    public float czas_strzelania = 3f;
    Transform gracz;

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
        transform.GetChild(i).transform.position = transform.position;
        transform.GetChild(i).gameObject.SetActive(true);
        
    }
}
