﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
     private float _speed = 4.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down at 4 mtr per sec 
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        //if bottom of scrn
        //respawn at top with a random x position
        if (transform.position.y < -5f)
        {
            float randomSpawn = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomSpawn, 7, 0);
        }
        
    }
    private void OnTriggerEnter(Collider other)
     {
         Debug.Log("Hit: " + other.transform.name);
         //if other is player 
         //damage the player
         //destroy us
            //Destroy(gameObject);
         //if other is laser
        //destroy laser
         //destroy us

    }
}
