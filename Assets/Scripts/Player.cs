using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;   //player speed
    

    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }


    void Update()
    {
        CalculateMovement();
    }
    void CalculateMovement() //player movement, area restriction
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical"); 
            //meters per sec speed 
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);  
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);  
            //(vertical axis movement restrictions)
        transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,3.8f,0),0);
            //(horizontal axis movement resrictions)
        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11.3f,transform.position.y,0);
        }
        else if (transform.position.x < -11.3f) 
        {
            transform.position = new Vector3(11.3f,transform.position.y,0);
        }
    }
}
