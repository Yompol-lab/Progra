using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;

    
    public GameObject[] fruitPrefabs;

 
    public Transform dropPosition;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"Enemigo recibió {damage} de daño. Vida restante: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("¡Enemigo eliminado!");
        DropFruit(); 
        Destroy(gameObject);
    }

    void DropFruit()
    {
        if (fruitPrefabs.Length > 0) 
        {
            int randomIndex = Random.Range(0, fruitPrefabs.Length); 
            Instantiate(fruitPrefabs[randomIndex], dropPosition.position, Quaternion.identity);
        }
    }
}
