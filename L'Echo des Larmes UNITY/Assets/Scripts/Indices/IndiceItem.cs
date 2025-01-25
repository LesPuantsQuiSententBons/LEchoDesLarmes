using System;
using UnityEngine;

public abstract class IndiceItem : MonoBehaviour
{
    public bool clickable = false;
    public GameObject dialogueBox;

    void OnMouseDown() {
        if (clickable) {
            Debug.Log("Tu as cliqué le " + this.GetType());
            dialogueBox.SetActive(true);
            GameObject.Find("inventaire" + GetType().ToString().Substring(6)).GetComponent<InventaireItem>().objetTrouve = true;
            this.gameObject.SetActive(false);
        }
    }
}