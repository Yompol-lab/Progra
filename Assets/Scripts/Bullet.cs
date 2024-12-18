using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyTime = 5f;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
    
    
    
    public int damage = 1; 

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage); 
            Destroy(gameObject); 
        }
    }
}