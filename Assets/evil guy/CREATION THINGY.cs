using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class CREATIONTHINGY : MonoBehaviour
{
    public GameObject[] path;
    public float Clocks;
    public int round;
    public around[] BAD;
    public void roundafter()
    {
        if (round+1 == BAD.Length)
        {
            return;
        }
        round += 1;
        new_round();
        Clocks = 0;
            
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        new_round();
    }
    private void new_round()
    {
        for (int i = 0; i < BAD[round].round_63.Length; i++)
        {
            BAD[round].round_63[i].MAny = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Clocks += Time.deltaTime;
        for (int i = 0; i < BAD[round].round_63.Length;i++)
        {
            var spwan_stuff=BAD[round].round_63[i];
            if (spwan_stuff.sheild.many > spwan_stuff.MAny&&spwan_stuff.sheild.when + spwan_stuff.sheild.spacing * spwan_stuff.MAny < Clocks)
            {
                GameObject banana=Instantiate(spwan_stuff.sheild.thingy);
                MARCH stealing = banana.GetComponent<MARCH>();
                stealing.THE_patH = path;
                stealing.egg();
                spwan_stuff.MAny += 1;
            }
        }
    }
}
