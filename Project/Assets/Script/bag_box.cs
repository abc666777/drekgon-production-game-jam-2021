using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bag_box : MonoBehaviour
{
    private Image img;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        img = GetComponent<Image>();
        //print(rb.position);
        //print(name);
    }

    void Update()
    {
        
    }
    void OnMouseEnter()
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, 255f);
    }

    void OnMouseExit()
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, 0.5882353f);
    }
}
