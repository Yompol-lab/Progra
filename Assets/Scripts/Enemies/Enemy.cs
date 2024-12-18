using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] fruitPrefabs; 
    public float dropChance = 0.5f;  

    public void TakeDamage(int damage)
    {
        
        
        DestroyEnemy();
    }

    void DestroyEnemy()
    {
      
        if (Random.value <= dropChance) 
        {
            GenerateRandomFruit();
        }

       
        Destroy(gameObject);
    }

    void GenerateRandomFruit()
    {
        
        int randomIndex = Random.Range(0, fruitPrefabs.Length);
        GameObject fruit = Instantiate(fruitPrefabs[randomIndex], transform.position, Quaternion.identity);

       
        Rigidbody2D rb = fruit.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(Vector2.up * 2f, ForceMode2D.Impulse); 
        }
    }
}
