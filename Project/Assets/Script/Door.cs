using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private double x_Coordinate;
    private double y_Coordinate;

    void Start()
    {
        //type_Door[Random.Range(0, 10)];
    }


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
        //go to room = Random.Range(0, 10);
    }
}
