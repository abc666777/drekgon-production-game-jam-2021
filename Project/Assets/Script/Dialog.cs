using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public string[] sentences;
    public GameObject dialog_box;
    public TextMeshProUGUI name_n;
    public TextMeshProUGUI text;
    private bool status_talk = false;
    private bool stel;
    public Memoto mmt;

    public void StarDialog()
    {
        status_talk = !status_talk;
        dialog_box.SetActive(status_talk);
    }
    // Start is called before the first frame update
    void Start()
    {
        stel = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void talking(string txt, string n) {
        if((n == "Mindflayer" || n == "Spacewalker" || n == "Phantom") && stel)
        {
            name_n.text = "???";
            stel = false;
        }
        else
        {
            stel = true;
            name_n.text = n;
        }
        text.text = txt;
    }
}
