using UnityEngine;

public class projectile : MonoBehaviour
{
    public float when_DIE;
    public bool want_hit;
    public float fast;
    public Rigidbody2D pyscis;
    public Vector2 face_somewhere;
    public int Pain;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pyscis = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(Vector2.zero, transform.position) > when_DIE)
        {
            Destroy(gameObject);
        }
     
    }
}
