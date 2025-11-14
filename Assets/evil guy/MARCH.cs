using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MARCH : MonoBehaviour
{
    public float distance;
    public float SQUISH;
    public int Vacation;
    public Rigidbody2D PYSICS_;
    public float MOVEMENT_FasT;
    public GameObject [] THE_patH;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void egg()
    {
        PYSICS_ = GetComponent<Rigidbody2D>();
        transform.position = THE_patH[0].transform.position;
        Vacation = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (THE_patH.Length == 0)
        {
            return;
        }
        transform.position = Vector2.MoveTowards(transform.position, THE_patH[Vacation].transform.position,MOVEMENT_FasT*Time.deltaTime);
        distance += MOVEMENT_FasT * Time.deltaTime;
        if (Vector2.Distance(transform.position, THE_patH[Vacation].transform.position) < SQUISH)
        {
            Vacation += 1;
            if (Vacation >= THE_patH.Length)
            {
                maneger000.instance.LIFE_change(-1);
                Destroy(gameObject);
            }
        } 
    }
}
