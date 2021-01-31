using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Encyclopedia : MonoBehaviour
{
    public List<NPC> Npcs;
    public List<string> Npcs_n;
    public List<string> Npcs_d;
    private bool status_Open = false;
    public GameObject encyclopedia_ui;
    public TextMeshProUGUI name_n;
    public TextMeshProUGUI text;
    public SpriteRenderer img_2;
    public List<SpriteRenderer> img;
    private int count;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        print(count + " : " + Npcs_n.Count);
        if (Input.GetKeyDown(KeyCode.RightArrow) && (count < Npcs_n.Count-1))
        {
               count++;
               show_data();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (count > 0))
        {
                count--;
                show_data();

        }
    }
    public void Action_Encyclopedia()
    {
        if (!status_Open)
        {
            print("Open encyclopedia");
            status_Open = !status_Open;
            show_data();
        }
        else
        {
            print("Close encyclopedia");
            status_Open = !status_Open;
        }
        encyclopedia_ui.SetActive(status_Open);
    }

    public void show_data()
    {
        img_2.GetComponent<SpriteRenderer>().sprite = img[count].sprite;
        img_2.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(200, 200, 5);
        name_n.text = Npcs_n[count];
        text.text = Npcs_d[count];
    }
}