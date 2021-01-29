using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bag_bg : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        panel.gameObject.SetActive(false);
    }
    public void hide_bg()
    {
        panel.gameObject.SetActive(false);
    }
    public void show_bg()
    {
        panel.gameObject.SetActive(true);
    }
}
