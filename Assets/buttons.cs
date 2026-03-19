using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject dart_monkey;
    public towerstart tower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void summon_tower()
    {
        if (GameManager.instance.Bananas >= tower.taxes)
        {
            Instantiate(dart_monkey);
            GameManager.instance.MoneyChange(-tower.taxes);
        }
    }
}
