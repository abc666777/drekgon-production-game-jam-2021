using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float move_Speed;
    private float x_Coordinate;
    private float y_Coordinate;
    private bool status_Open_Bag = false;
    private bool status_Open_Encyclopedia = false;
    //Cast to npc, door, momento
    private Bag bag = new Bag();
    private Encyclopedia encyclopedia = new Encyclopedia();

    private float moveinput;

    private Rigidbody2D rb;

    private bool facing = true; //true = right, flast = left

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        moveinput = Input.GetAxis("Horizontal"); // move Horizontal
        //Debug.Log(moveinput);
        rb.velocity = new Vector2(moveinput * move_Speed, rb.velocity.y);
        if (facing == true && moveinput < 0) {
            Flip();
        }else if (facing == false && moveinput > 0) {
            Flip();
        }

        call_Bag();
        call_Encyclopedia(); 
    }

    void Flip()
    {
        facing = !facing;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    
    public void call_Bag()//check I button
    {
        if (Input.GetKeyDown("i") && !status_Open_Bag)
        {
            bag.Open_Bag();
            status_Open_Bag = !status_Open_Bag;
        }
        else if (Input.GetKeyDown("i") && status_Open_Bag)
        {
            bag.Close_Bag();
            status_Open_Bag = !status_Open_Bag;
        }
    }
    public void call_Encyclopedia()//check O button
    {
        if (Input.GetKeyDown("o") && !status_Open_Encyclopedia)
        {
            encyclopedia.Open_Encyclopedia();
            status_Open_Encyclopedia = !status_Open_Encyclopedia;
        }
        else if (Input.GetKeyDown("o") && status_Open_Encyclopedia)
        {
            encyclopedia.Close_Encyclopedia();
            status_Open_Encyclopedia = !status_Open_Encyclopedia;
        }
    }
}
