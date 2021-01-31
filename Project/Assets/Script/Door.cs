using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private double x_Coordinate;
    private double y_Coordinate;
    public Game_System sys;
    private bool status_talk = false;

    public Animator transitionAnim;
    public string sceneName;

    void Start()
    {}


    void Update()
    {
        
    }

    public void set_Coordinate_Door(double x, double y)//system random coordinate for door
    {
        x_Coordinate = x;
        y_Coordinate = y;
    }

    public void random_Room()//cast player for check press Enter for call this function
    {
        if (status_talk)
        {
            print("It is a door");
            sys.random_bg();
            StartCoroutine(LoadScene());
        }
        else
        {
            print("Please Talk Npc before");
        }
    }
    public bool StatusTalk { 
        get { return status_talk; }
        set { status_talk = value; }
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        StopCoroutine(LoadScene());
        transitionAnim.SetTrigger("start");
    }
}
