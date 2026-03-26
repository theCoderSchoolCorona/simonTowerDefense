using Unity.VisualScripting;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static Settings instance;
    public AudioClip buckroundSong;
    public float soundVolume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
