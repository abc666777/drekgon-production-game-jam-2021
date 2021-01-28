using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float move_Speed;
    private float x_Coordinate;
    private float y_Coordinate;
    //Cast to npc, door, momento
    
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
        Debug.Log(moveinput);
        rb.velocity = new Vector2(moveinput * move_Speed, rb.velocity.y);
        if (facing == true && moveinput < 0) {
            Flip();
        }else if (facing == false && moveinput > 0) {
            Flip();
        }
    }

    void Flip()
    {
        facing = !facing;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    
    public void open_Bag()//check I button
    {

    }
    public void open_Encyclopedia()//check O button
    {

    }
}
