using TMPro;
using UnityEngine;

public class life : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI bananananananananana;
    private void updatei()
    {
        bananananananananana.text = "lives" + GameManager.instance.playerHealth.ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.OnChangeLife.AddListener(updatei);
        updatei();
    }

    // Update is called once per frame
    void Update()
    {
        updatei();
    }
}
