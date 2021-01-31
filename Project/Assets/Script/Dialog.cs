using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public string[] sentences;
    public GameObject dialog_box;
    public GameObject name;
    public GameObject text;
    private bool status_talk = false;

    public void StarDialog()
    {
        status_talk = !status_talk;
        dialog_box.SetActive(status_talk);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void talking(string txt, string n) {
        print(n + " : " + txt);
    }
}
