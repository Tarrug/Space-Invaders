﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //speed var 8
    [SerializeField]
    private float _speed = 8.0f;
    void Update()
    {
        //translate laser up
        transform.Translate(Vector3.up *_speed * Time.deltaTime);
        if (transform.position.y > 8.0f)
        {
            Destroy(gameObject);
        }
    }
}
