using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //img
    private string name_Npc;
    private int ID;
    private List<string> data_Detail;//get form text data
    private Memoto Memoto;
    private Rigidbody2D rb_npc;
    public Door door;

    void Start()
    {
        rb_npc = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public Memoto give_Memento()
    {
        return Memoto;
    }
    
    public void take_Memento()
    {

    }
    public void talk()
    {
        print("Hi my name is ...");
        door.StatusTalk = true;
    }

    public Rigidbody2D Rb_Npc
    {
        get { return rb_npc; }
        set { rb_npc = value; }
    }
}
