using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : MonoBehaviour
{

    public GameObject openDoor;
    public GameObject closedDoor;

    //public PlayerInventory playerInventory;

    private bool isOpen = false;
    public bool isInTrigger = false;

    void OpenDoor()
    {
        openDoor.SetActive(true);
        closedDoor.SetActive(false);
    }

    void CloseDoor()
    {
        openDoor.SetActive(false);
        closedDoor.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInTrigger)
        {
            if(isOpen)
            {
                CloseDoor();
                isOpen = false;
            }
            else
            {
                OpenDoor();
                isOpen = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInTrigger = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInTrigger = false;
        }
    }
}
