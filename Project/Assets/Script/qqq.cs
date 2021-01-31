using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qqq : MonoBehaviour
{
    public bool cho;
    public NPC npc;
    void Start()
    {
        cho = true;
    }

    void Update()
    {
        if(Input.GetKeyDown("y")){
            npc.ans(true);
        }
        else if (Input.GetKeyDown("n"))
        {
            npc.ans(false);
        }
    }
}
