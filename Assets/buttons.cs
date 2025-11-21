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
        if (maneger000.instance.Bananas >= tower.taxes)
        {
            Instantiate(dart_monkey);
            maneger000.instance.MONEY_change(-tower.taxes);
        }
    }
}
