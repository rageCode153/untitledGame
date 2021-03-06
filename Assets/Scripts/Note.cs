using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public Image noteImage;
    public KeyCode interactKey;
    public bool isOpen;
    public bool isInRange;

    private void Update()
    {
        if(isInRange && Input.GetKeyDown(interactKey))
        {
            if(isOpen)
            {
                CloseNote();
                isOpen = false;
            }
            else
            {
                OpenNote();
                isOpen = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
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

    public void OpenNote()
    {
        noteImage.enabled = true;
    }

    public void CloseNote()
    {
        noteImage.enabled = false;
    }
}
