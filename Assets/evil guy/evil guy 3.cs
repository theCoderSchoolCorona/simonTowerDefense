using UnityEngine;

public class evilguy3 : MonoBehaviour
{
    public int LIFE;
    public int GAIN;
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
        if (collision.TryGetComponent<projectile>(out projectile PAIN))
        {
            LIFE -= PAIN.Pain;
            if (LIFE <= 0)
            {
                maneger000.instance.MONEY_change(GAIN);
                Destroy(gameObject);
            }
        }
    }
}
