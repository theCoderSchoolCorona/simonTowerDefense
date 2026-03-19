using UnityEngine;

public class LaserTower : towerstart
{
    private LineRenderer line;
    private Enemy target = null;

    public void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    public override void Update()
    {
        base.Update();

        LineVisual();
    }

    public override void Attack()
    {
        LayerMask masK = LayerMask.GetMask("banana");
        var inrange = Physics2D.CircleCastAll(gameObject.transform.position, area_of_sight, Vector2.zero, 50f, masK);
        EnemyMarch march;
        if (inrange.Length == 0)
        {
            return;
        }
        march = inrange[0].transform.gameObject.GetComponent<EnemyMarch>();
        Enemy enemy = march.transform.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            target = enemy;
        }


        foreach (var enemyPathfind in inrange)
        {
            EnemyMarch newMarch = enemyPathfind.transform.GetComponent<EnemyMarch>();
            if (newMarch.distance > march.distance)
            {
                march = newMarch;
            }
        }
        if (march)
        {
            enemy.Damage(bullet.gameObject.GetComponent<projectile>());
        }
    }
    private void LineVisual ()
    {
        if (target != null)
        {
            Debug.Log(target.transform.GetInstanceID());
            line.enabled = true;
            line.SetPosition(0, gameObject.transform.position);
            line.SetPosition(1, target.transform.position);
        }
        else
        {
            line.enabled = false;
        }
    }
}
