using UnityEngine;
using UnityEngine.SceneManagement;

public class secenManeger : MonoBehaviour
{
    public bool aresettingthrere;
    public static secenManeger instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (aresettingthrere)
            {
                unloadsecen("Settings");
                aresettingthrere = false;
            }
            else
            {
                secenloadadd("Settings");
                aresettingthrere = true;
            }
        }
    }
    public void secenload(string secenname)
    {
        SceneManager.LoadScene(secenname);
    }
    public void secenloadadd(string secenname)
    {
        SceneManager.LoadScene(secenname,LoadSceneMode.Additive);
    }
    public void unloadsecen(string secenname)
    {
        SceneManager.UnloadSceneAsync(secenname);
    }

}
