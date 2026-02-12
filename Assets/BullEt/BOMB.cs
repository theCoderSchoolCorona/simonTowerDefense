using UnityEditor.Tilemaps;
using UnityEngine;

public class BOMB : projectile
{
    public GameObject BOX;
    public override void explode()
    {
        var evil = Instantiate(BOX, transform.position, transform.rotation);
        evil.GetComponent<projectile>().Pain = Pain;
        base.explode();
        
    }
}
