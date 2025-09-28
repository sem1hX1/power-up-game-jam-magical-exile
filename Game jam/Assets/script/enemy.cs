using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public string enHurt;
    public Animator anim;
    public int maxHealth = 100;
    int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        anim.SetTrigger("enHurt");

        if (currentHealth <= 0)
        {
            Die();
        }
        void Die()
        {

            anim.SetBool("edied", true);

            this.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 2f);


        }

    }
}
