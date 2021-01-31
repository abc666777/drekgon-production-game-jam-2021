using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public List<Memoto> Mementos;
    public bool status_Open = false;
    public bag_bg bg;
    public List<bg_box> bb;
    public bg_box df;
    void Start()
    {
        Mementos = new List<Memoto>();
    }

    void Update()
    {
    }

    public void Action_Bag()
    {
        if (!status_Open)
        {
            bg.show_bg();
            status_Open = !status_Open;
            show();
        }
        else
        {
            bg.hide_bg();
            status_Open = !status_Open;
        }
    }

    public void show()
    {
        for(int i = 0;i < Mementos.Count; i++)
        {
            bb[i].GetComponent<SpriteRenderer>().sprite = Mementos[i].GetComponent<SpriteRenderer>().sprite;
        }
        for (int i = Mementos.Count; i < 15; i++)
        {
            bb[i].GetComponent<SpriteRenderer>().sprite = df.GetComponent<SpriteRenderer>().sprite;
        }
    }

}
