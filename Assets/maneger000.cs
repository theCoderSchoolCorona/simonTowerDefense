using UnityEngine;
using UnityEngine.Events;

public class maneger000 : MonoBehaviour
{
    public UnityEvent changeMONEYYYYY;
    public UnityEvent changeLIFEEEEEE;
    public Camera cam;
    public int LIFE;
    public GameObject GameOver;
    public int Bananas;
    public static maneger000 instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

        instance = this;
        MONEY_change(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LIFE_change(int change)
    {
        LIFE += change;
        Debug.Log("THE AMOUNT YOU LIVE IS THIS" + LIFE);
        if (LIFE <= 0)
        {
            GameOver.SetActive(true);
        }
        changeLIFEEEEEE.Invoke();
    }
    public void MONEY_change(int change)
    {
        Bananas += change;
        changeMONEYYYYY.Invoke();
        Debug.Log("THE AMOUNT YOU HAVE IS THIS" + Bananas);
    }

}
