using UnityEngine;

public class i_have_no_idea : towerstart
{
    public override void Attack()
    {
        LayerMask masK = LayerMask.GetMask("banana");
        var inrange = Physics2D.CircleCastAll(gameObject.transform.position, area_of_sight, Vector2.zero,50f,masK);
        EnemyMarch far;

        if (inrange.Length == 0)
        {
            return;
        }
        far = inrange[0].transform.gameObject.GetComponent<EnemyMarch>();
        foreach (var evilguy in inrange)
        {
            EnemyMarch THEevilguy = evilguy.transform.GetComponent<EnemyMarch>();
            if (THEevilguy.distance > far.distance)
            {
                far = THEevilguy;
            }
        }
        if (far)
        {
            GameObject Cannonball = Instantiate(bullet);
            Cannonball.transform.position = transform.position;
            var degres = Mathf.Atan2(far.transform.position.y - transform.position.y, far.transform.position.x - transform.position.x);
            Vector2 directIOn = new Vector2(Mathf.Cos(degres), Mathf.Sin(degres))*SPEEEEEEEEED;
            Cannonball.GetComponent<projectile>().Pain = PAINN;
            Cannonball.GetComponent<Rigidbody2D>().linearVelocity = directIOn;
        }

        
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, area_of_sight);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
