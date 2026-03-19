using TMPro;
using UnityEngine;

public class MONEY : MonoBehaviour
{

    public TextMeshProUGUI bananananananananana;
    private void updatei()
    {
        bananananananananana.text = "Money" + GameManager.instance.Bananas.ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.OnChangeMoney.AddListener(updatei);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
