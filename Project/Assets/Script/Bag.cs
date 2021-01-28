using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    private List<Memoto> Mementos;
    private string name;
    void Start()
    {
        this.name = "Hello";
    }

    void Update()
    {
        Debug.Log(name);
    }

    public void Open_Bag()
    {
        print("Open bag");
    }
    public void Close_Bag()
    {
        print("Close bag");
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
    public void Set_Name(string n)
    {
        this.name = n;
    }

    public string Get_Name()
    {
        return name;
    }
}
