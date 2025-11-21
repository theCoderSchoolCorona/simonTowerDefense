using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class towerstart : MonoBehaviour
{
    public int taxes;
    public GameObject bullet;
    public float area_of_sight;
    public CircleCollider2D Area_circlE;
    public float SPEEEEEEEEED;
    public float attack_sped;
    public float timer_;
    public int PAINN;
    public bool placed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            placed = true;
        }
        if (!placed)
        {
            transform.position = maneger000.instance.cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            return;
        }
        timer_ += Time.deltaTime;
        if (timer_ > attack_sped)
        {
            pew_pew();
            timer_ = 0;
        }
    }

    public abstract void pew_pew();
}
