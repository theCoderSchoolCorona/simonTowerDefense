using TMPro;
using UnityEngine;

public class Round : MonoBehaviour
{
    public CREATIONTHINGY CREATIONTHINGY;
    public TextMeshProUGUI bananananananananana;
    private void updatei()
    {
        bananananananananana.text = "Round" + (CREATIONTHINGY.round+1).ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CREATIONTHINGY.on_the_roun_of_newest.AddListener(updatei);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
