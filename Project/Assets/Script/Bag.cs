using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public List<Memoto> Mementos;
    public bool status_Open = false;
    public bag_bg bg;
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
            print("Open bag");
            bg.show_bg();
            status_Open = !status_Open;
        }
        else
        {
            print("Close bag");
            bg.hide_bg();
            status_Open = !status_Open;
        }
    }

    public void Set_Mementos(Memoto item)
    {
        Mementos.Add(item);
    }

    public Memoto Get_Mementos()
    {
        if (Mementos.Count == 0)
        {
            return null;
        }
        else
        {
            return Mementos[0];
        }
    }

}
