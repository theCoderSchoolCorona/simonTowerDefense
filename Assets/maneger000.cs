using UnityEngine;

public class maneger000 : MonoBehaviour
{
    public Camera cam;
    public int LIFE;
    public int Bananas;
    public static maneger000 instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LIFE_change(int change)
    {
        LIFE += change;
        Debug.Log("THE AMOUNT YOU LIVE IS THIS" + LIFE);
    }
    public void MONEY_change(int change)
    {
        Bananas += change;
        Debug.Log("THE AMOUNT YOU HAVE IS THIS" + Bananas);
    }

}
