using TMPro;
using UnityEngine;

public class MONEY : MonoBehaviour
{

    public TextMeshProUGUI bananananananananana;
    private void updatei()
    {
        bananananananananana.text = "Money" + maneger000.instance.Bananas.ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maneger000.instance.changeMONEYYYYY.AddListener(updatei);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
