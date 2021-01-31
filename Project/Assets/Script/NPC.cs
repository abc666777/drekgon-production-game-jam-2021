using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //img
    public string name_Npc;
    public int count = 0;
    public string[] npc_sentences;
    public List<string> command;
    public List<string> conversation;//get form text data
    public Rigidbody2D rb_npc;
    public Door door;
    public Game_System sys;
    public Dialog dialog_box;
    public Player py;


    void Start()
    {
        rb_npc = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }


    public void talk()
    {
        if (count == 0)
        {
            dialog_box.StarDialog();
        }
        else if (count == command.Count)
        {
            this.gameObject.SetActive(false);
            door.StatusTalk = true;
            dialog_box.StarDialog();
            py.walk = true;
        }
        if (count != command.Count)
        {

            dialog_box.talking(conversation[count], name_Npc);
            if (command[count] == "q")
            {
                //if (true)//Yes
                //{
                // i++;
                //}
            }
            else if (command[count] == "a")
            {
                sys.take_Memento(command[count]);
            }
            else if (command[count] == "c")
            {
                //sys.take_Memento(command[count]);
            }
            else if (command[count] == "d")
            {
                sys.take_Memento(command[count]);
            }
            else if (command[count] == "g")
            {
                sys.give_Memento();
            }
        }
        count++;
    }

    public Rigidbody2D Rb_Npc
    {
        get { return rb_npc; }
        set { rb_npc = value; }
    }
}
