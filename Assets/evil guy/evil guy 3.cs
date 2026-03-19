using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int gain;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<projectile>(out projectile PAIN))
        {
            Damage(PAIN);
        }
    }

    public void Damage(projectile PAIN)
    {
        health -= PAIN.Pain;
        PAIN.pirce -= 1;
        if (PAIN.pirce <= 0)
        {
            PAIN.explode();
            Debug.Log("AHH");
        }
        if (health <= 0)
        {
            GameManager.instance.MoneyChange(gain);
            Destroy(gameObject);
        }
    }
}