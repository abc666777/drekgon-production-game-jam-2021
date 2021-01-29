using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Room : MonoBehaviour
{
    private List<Sprite> BackgroundList;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void random_bg()
    {
        BackgroundList = Resources.LoadAll<Sprite>("Background").ToList();
        GetComponent<SpriteRenderer>().sprite = BackgroundList[(int)Random.Range(0, BackgroundList.Count)];

    }
}
