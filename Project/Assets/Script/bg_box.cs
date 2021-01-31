using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bg_box : MonoBehaviour
{
    private Image img;
    public Game_System sys;
    public Bag bbb;
    public Dialog dialog_box;
    void Start()
    {
        img = GetComponent<Image>();
    }

    void Update()
    {
    }

    void OnMouseEnter()
    {
        //img.color = new Color(img.color.r, img.color.g, img.color.b, 1f);
    }
    void OnMouseExit()
    {
        //img.color = new Color(img.color.r, img.color.g, img.color.b, 0.7843137f);
    }

    private void OnMouseDown()
    {
        if (sys.count  == 11)
        {
            for (int i = 0; i < bbb.Mementos.Count; i++)
            {
                if (bbb.Mementos[i].GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
                {
                    dialog_box.talking(bbb.Mementos[i].endding(), "");
                    dialog_box.dialog_box.SetActive(true);
                    bbb.Mementos[i].endding();
                    break;
                }
            }
            bbb.Action_Bag();
        }
    }
}
