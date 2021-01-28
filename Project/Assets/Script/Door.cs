using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Door : MonoBehaviour
{
    private double x_Coordinate;
    private double y_Coordinate;
    private List<Sprite> BackgroundList;

    void Start()
    {
        BackgroundList = Resources.LoadAll<Sprite>("Background").ToList();
        GetComponent<SpriteRenderer>().sprite = BackgroundList[(int) Random.Range(0, BackgroundList.Count)];
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
        print("It is a door");
    }
}
