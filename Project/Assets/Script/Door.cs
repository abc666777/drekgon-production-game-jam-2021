using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Door : MonoBehaviour
{
    private double x_Coordinate;
    private double y_Coordinate;
    public Room room;
    private bool status_talk = false;

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
            room.random_bg();
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

    }
