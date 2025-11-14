using UnityEngine;

public abstract class towerstart : MonoBehaviour
{
    public GameObject bullet;
    public float area_of_sight;
    public CircleCollider2D Area_circlE;
    public float SPEEEEEEEEED;
    public float attack_sped;
    public float timer_;
    public int PAINN;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        timer_ += Time.deltaTime;
        if (timer_ > attack_sped)
        {
            pew_pew();
            timer_ = 0;
        }
    }

    public abstract void pew_pew();
}
