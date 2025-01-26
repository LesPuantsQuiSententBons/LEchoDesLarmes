using System;
using UnityEngine;

public abstract class DeclenchageScript : MonoBehaviour
{
    public GameObject dialogueBox;
    public bool clickable = true;

    void OnMouseDown() {
        if (clickable) {
            Debug.Log("Tu as cliqué le " + this.GetType());
            dialogueBox.SetActive(true);
            clickable = false;
        }
    }
}