using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public GameObject bullet;
    Transform gracz;

    void Start()
    {
        gracz = GameObject.Find("postac").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, gracz.transform);
        }
    }
}
