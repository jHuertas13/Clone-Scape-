using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{ 
    public bool Close = true;
    public Sprite openDoor;
    public Sprite closeDoor;
    // private Animator animator;
    private void Start()
    {
        closeDoor = GetComponent<SpriteRenderer>().sprite;
    }

    private void FixedUpdate()
    {


        if (!Close)
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = openDoor;
            // animator.SetBool("Open?",true);

        }
        if(Close)
        {
            GetComponent<Collider2D>().enabled = true;
            GetComponent<SpriteRenderer>().sprite = closeDoor;

        }
    }

}
