using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemInteraction : MonoBehaviour
{
    public bool isInRange=false;
    public bool isOpen;
    public KeyCode interactKey;
    public UnityEvent interactActionOpen;
    public UnityEvent interactActionClose;

    private void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                if (isOpen)
                {
                    interactActionClose.Invoke();
                    isOpen = false;
                }
                else
                {
                    interactActionOpen.Invoke();
                    isOpen = true;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
}
