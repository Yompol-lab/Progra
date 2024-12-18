using UnityEngine;

public class FastEnemyMovement : MonoBehaviour
{
    public float speed = 5f; 
    public Transform target; 

    void Update()
    {
        if (target != null)
        {
            
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
