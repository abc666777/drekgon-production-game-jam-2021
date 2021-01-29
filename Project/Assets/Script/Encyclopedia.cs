using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encyclopedia : MonoBehaviour
{
    private List<NPC> Npcs;
    private bool status_Open = false;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Action_Encyclopedia()
    {
        if (!status_Open)
        {
            print("Open encyclopedia");
            status_Open = !status_Open;
        }
        else
        {
            print("Close encyclopedia");
            status_Open = !status_Open;
        }
    }
}
