using UnityEngine;

public class LaserTower : towerstart
{
    private LineRenderer line;

    public void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    public override void Attack()
    {
        LayerMask masK = LayerMask.GetMask("banana");
        var inrange = Physics2D.CircleCastAll(gameObject.transform.position, area_of_sight, Vector2.zero, 50f, masK);
        MARCH enemy;
        if (inrange.Length == 0)
        {
            return;
        }
        enemy = inrange[0].transform.gameObject.GetComponent<MARCH>();
        foreach (var evilguy in inrange)
        {
            MARCH THEevilguy = evilguy.transform.GetComponent<MARCH>();
            if (THEevilguy.distance > enemy.distance)
            {
                enemy = THEevilguy;
            }
        }
        if (enemy)
        {
            line.enabled = true;
            line.SetPosition(0, gameObject.transform.position);
            line.SetPosition(1, enemy.transform.position);
        }
        else
        {
            line.enabled = false;
            Debug.Log("Go away");
        }
    }
}
