using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class Game_System : MonoBehaviour
{
    public List<data_npc> npcs;
    public List<data_mmt> mmts;
    private Memoto mmt;
    public Memoto mmt2;
    public NPC npc;
    public Player py;
    public Bag bag;
    private List<Sprite> BackgroundList;
    private List<Sprite> sp_npc;
    private List<Sprite> Bg_Mmt_List;
    public Room room;
    public int count = 0;
    void Start()
    {
        npcs = new List<data_npc>();
        mmts = new List<data_mmt>();
        load_json();
        set_npc(5);
        BackgroundList = Resources.LoadAll<Sprite>("Background").ToList();
        Bg_Mmt_List = Resources.LoadAll<Sprite>("Momento").ToList();
        sp_npc = Resources.LoadAll<Sprite>("Npc").ToList();

    }

    void Update()
    {
    }
    public void give_Memento()
    {
        int ran = Random.Range(0, mmts.Count);
        foreach(Sprite sp in Bg_Mmt_List)
        {
            if(sp.name == mmts[ran].name)
            {
                mmt2.GetComponent<SpriteRenderer>().sprite = sp;
                break;
            }
        }
        mmt = Instantiate(mmt2, new Vector3(-15, 10, 1), Quaternion.identity);
        mmt.transform.localScale = new Vector3(0.2f, 0.2f, 1);
        
        mmt.name_Memoto = mmts[ran].name;
        mmt.name = mmts[ran].name;
        mmt.story = mmts[ran].story;
        mmt.ending = mmts[ran].ending;
        bag.Mementos.Add(mmt);
        mmts.RemoveAt(ran);
    }

    public void take_Memento(string type)
    {
        if (bag.Mementos.Count != 0) { 
            if (type == "a")
            {
               bag.Mementos.Clear();

            }else if (type == "c")
            {
                int ran = Random.Range(0, bag.Mementos.Count);
                bag.Mementos.RemoveAt(ran);
                give_Memento();
            }
            else
            {
                int ran = Random.Range(0, bag.Mementos.Count);
                bag.Mementos.RemoveAt(ran);
            }
        }
    }

    public void ran_npc()
    {
        npc.gameObject.SetActive(true);
        if (count < 11)
        {
            int ran = (int)Random.Range(0, 7);
            while (ran == 5) { ran = (int)Random.Range(0, 7); }
            set_npc(ran);
        }
        else
        {
            set_npc(7);
        }
    }
    public void set_npc(int index)
    {
        foreach (Sprite sp in sp_npc)
        {
            if (sp.name == npcs[index].name)
            {
                npc.GetComponent<SpriteRenderer>().sprite = sp;
                break;
            }
        }
        npc.count = 0;
        npc.name_Npc = npcs[index].name;
        npc.story = npcs[index].story;
        npc.conversation = npcs[index].conversation;
        npc.command = npcs[index].command;
    }

    public void load_json()
    {
        string json;
        data_npc npc;
        data_mmt mmt;
        for (int i = 1; i < 9; i++)
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
    public void random_bg()
    {
        if (count < 11)
        {
            room.GetComponent<SpriteRenderer>().sprite = BackgroundList[(int)Random.Range(0, BackgroundList.Count)];
            count++;
        }
        else
        {
            room.GetComponent<SpriteRenderer>().sprite = BackgroundList[0];
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
