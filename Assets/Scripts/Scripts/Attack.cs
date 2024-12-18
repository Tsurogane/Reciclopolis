using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyMeleeController enemy = collision.GetComponent<EnemyMeleeController>();

        // Tenta pegar o componente PlayerController
        PlayerController player = collision.GetComponent<PlayerController>();

        // Se a colisão foi com um inimigo e o componente EnemyMeleeController foi encontrado
        if (enemy != null)
        {
            // Inimigo recebe dano
            enemy.TakeDamage(damage);
        }
        else if (player != null)
        {
            // Se a colisão foi com um player e o componente PlayerController foi encontrado
            player.TakeDamage(damage);
        }
    }

}
