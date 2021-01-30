using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //img
    public string name_Npc;
    public int ID;
    public string[] npc_sentences;
    public List<string> conversation;//get form text data
    public Rigidbody2D rb_npc;
    public Door door;
    public Game_System sys;
    public Dialog dialog_box;


    void Start()
    {
        rb_npc = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public void give_Memento()
    {
    }

    public void take_Memento()
    {

    }
    public void talk()
    {
        dialog_box.StarDialog();
        print("Hi my name is "+ name_Npc);
        door.StatusTalk = true;
    }

    public Rigidbody2D Rb_Npc
    {
        get { return rb_npc; }
        set { rb_npc = value; }
    }
}
