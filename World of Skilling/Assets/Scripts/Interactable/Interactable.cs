using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour {

    private bool clickable = false;

    private void OnMouseOver()
    {
        //Debug.Log("Mouse is over GameObject");
    }

    private void OnMouseDown()
    {
        if(clickable)
        {
            Interact();
        }
        else
        {
            MoveToInteractable();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Player")
        {
            clickable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name=="Player")
        {
            clickable = false;
        }
    }

    private void MoveToInteractable()
    {
        Debug.Log("Add code to move to Interactable");
    }

    protected abstract void Interact();
}
