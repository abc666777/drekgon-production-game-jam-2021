using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Game_System : MonoBehaviour
{
    public List<data_npc> npcs;
    public List<data_mmt> mmts;
    public NPC npc;
    public Player py;
    public Bag bag;
    void Start()
    {
        npcs = new List<data_npc>();
        mmts = new List<data_mmt>();
        load_json();
        set_npc(5);

    }

    void Update()
    {
        
    }

    public void ran_npc()
    {
        set_npc((int)Random.Range(0, 7));
    }
    public void set_npc(int index)
    {
        npc.name_Npc = npcs[index].name;
        npc.conversation = npcs[index].conversation;
    }

    public void load_json()
    {
        string json;
        data_npc npc;
        data_mmt mmt;
        for (int i = 1; i < 8; i++)
        {
            json = File.ReadAllText(Application.dataPath + "/Json/npc_" + i + ".json");
            npc = JsonUtility.FromJson<data_npc>(json);
            npcs.Add(npc);
        }
        for (int i = 1; i < 12; i++)
        {
            json = File.ReadAllText(Application.dataPath + "/Json/mmt_" + i + ".json");
            mmt = JsonUtility.FromJson<data_mmt>(json);
            mmts.Add(mmt);
        }
    }

    public class data_npc
    {
        public string name;
        public string story;
        public string img;
        public string true_img;
        public List<string> command;
        public List<string> conversation;
    }
    public class data_mmt
    {
        public string name;
        public string cg;
        public string story;
        public string ending;
    }
}
