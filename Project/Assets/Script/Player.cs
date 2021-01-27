using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private double move_Speed;
    private double x_Coordinate;
    private double y_Coordinate;
    //Cast to npc, door, momento

    void Start()
    {
        move_Speed = 10;
        x_Coordinate = 0;
        y_Coordinate = 0;
    }

    void Update()
    {

    }

    public void move(string direction)
    {
        // if (direction == "East")
        // {
        //     x_Coordinate += move_Speed;
        // }if (direction == "West")
        // {
        //     x_Coordinate -= move_Speed;
        // }if (direction == "North")
        // {
        //     y_Coordinate += move_Speed;
        // }if (direction == "South")
        // {
        //     y_Coordinate -= move_Speed;
        // }
    }

    public void open_Bag()//check I button
    {

    }
    public void open_Encyclopedia()//check O button
    {

    }
}
