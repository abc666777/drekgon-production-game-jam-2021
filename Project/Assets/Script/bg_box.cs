using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bg_box : MonoBehaviour
{
    private Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
    }

    void OnMouseEnter()
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, 1f);
    }
    void OnMouseExit()
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, 0.7843137f);
    }
}
