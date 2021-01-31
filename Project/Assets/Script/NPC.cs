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
    public string story;
    public List<string> conversation;//get form text data
    public Rigidbody2D rb_npc;
    public Door door;
    public Game_System sys;
    public Dialog dialog_box;
    public Player py;
    public GameObject qqq_ui;
    public qqq qqq;
    public Encyclopedia en;
    public bool inn;


    void Start()
    {
        rb_npc = GetComponent<Rigidbody2D>();
        inn = true;
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
        else if (count >= command.Count)
        {
            this.gameObject.SetActive(false);
            door.StatusTalk = true;
            dialog_box.StarDialog();
            py.walk = true;
        }
        if (count != command.Count)
        {
            foreach (string nnn in en.Npcs_n)
            {
                if (nnn != name_Npc)
                {
                    print(nnn +" : " +name_Npc);
                    inn = true;
                }
            }
            if (inn)
            {
                en.Npcs_n.Add(name_Npc);
                en.Npcs_d.Add(story);
                en.img.Add(GetComponent<SpriteRenderer>());
                inn = false;
            }
            dialog_box.talking(conversation[count], name_Npc);
            if (command[count] == "q")
            {
                qqq_ui.SetActive(true);
                qqq.cho = false;
            }
            else if (command[count] == "y")
            {
                sys.take_Memento(command[count]);
                count++;
            }
            else if (command[count] == "a")
            {
                sys.take_Memento(command[count]);
            }
            else if (command[count] == "c")
            {
                sys.take_Memento(command[count]);
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

    public void ans(bool ans)
    {
        if (!ans)
        {
            count++;
        }
        qqq_ui.SetActive(false);
        qqq.cho = true;
        talk();
    }

}
