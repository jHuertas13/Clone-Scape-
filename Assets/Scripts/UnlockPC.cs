using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockPC : MonoBehaviour
{
    public bool locked = true;

    public bool IsButton = false;
    public OpenDoor doorToOpen;

    [SerializeField] Sprite OpenSprite;


    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("in");
        if (locked)
        {
            Unlock();
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Out");

        if (IsButton)
        {
            Unlock();
        }
    }

    public void Unlock()
    {
        GetComponent<SpriteRenderer>().sprite = OpenSprite;
        locked = !locked;
        doorToOpen.Close = !doorToOpen.Close;
    }


}
