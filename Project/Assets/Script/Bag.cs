using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public List<Memoto> Mementos;
    public bool status_Open = false;
    void Start()
    {
    }

    void Update()
    {
        //Debug.Log(name);
    }

    public void Action_Bag()
    {
        if (!status_Open)
        {
            print("Open bag");
            status_Open = !status_Open;
        }
        else
        {
            print("Close bag");
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
