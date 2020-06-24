using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
     private float _enemyDownRate = 4f;
     [SerializeField]
     private float _canEnemyDown = -1f;
     private GameObject _enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move down at 4 mtr per sec 
        _canEnemyDown = Time.time + _enemyDownRate;
        Instantiate(_enemyPrefab,transform.position + new Vector3 (0,0.8f,0),Quaternion.identity); 
        
        //if bottom of scrn
        //respawn at top with a random x position
    }
}
