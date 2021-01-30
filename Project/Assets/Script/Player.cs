using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float move_Speed;

    private enum play_status
    {
        moving,
        talking,
        open_bag,
        open_encyclopedia
    };
    private float x_Coordinate;
    private float y_Coordinate;
    private bool status_Door = false;
    private bool status_Npc = false;
    public Bag bag;
    public Encyclopedia encyclopedia;
    public Door door;
    public NPC npc;
    public Dialog dialog_box;

    private float moveinput;

    private Rigidbody2D rb;

    private bool facing = true; //true = right, flast = left

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        x_Coordinate = rb.position.x;
        y_Coordinate = rb.position.y;
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


        if (Input.GetKeyDown("i")) {//call bag
            bag.Action_Bag();
        }

        if (Input.GetKeyDown("o")) {//call Encyclopedia
            encyclopedia.Action_Encyclopedia();
        }
        if (Input.GetKeyDown(KeyCode.Return) && status_Door)
        {
            door.random_Room();
            if (door.StatusTalk){
                rb.position = new Vector3(x_Coordinate, y_Coordinate, 1);
                door.StatusTalk = false;
                npc.Rb_Npc.position = new Vector3(Random.Range(-0.961f, 5.049f), npc.Rb_Npc.position.y, 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.Return) && status_Npc)
        {
            npc.talk();
        }
    }

    void Flip()
    {
        facing = !facing;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Door")
        {
            status_Door = true;
        }else if (other.name == "Npc")
        {
            status_Npc = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Door")
        {
            status_Door = false;
        }else if (other.name == "Npc")
        {
            status_Npc = false;
        }
    }

}
