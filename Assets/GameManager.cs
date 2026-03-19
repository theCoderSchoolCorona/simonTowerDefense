using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UnityEvent OnChangeMoney;
    public UnityEvent OnChangeLife;

    public Camera cam;
    public int playerHealth;
    public GameObject GameOver;
    public int Bananas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);

        MoneyChange(0);
    }

    public void UpdateHealth(int change)
    {
        playerHealth += change;
        if (playerHealth <= 0)
        {
            GameOver.SetActive(true);
        }
        OnChangeLife.Invoke();
    }
    public void MoneyChange(int change)
    {
        Bananas += change;
        OnChangeMoney.Invoke();
    }

}
