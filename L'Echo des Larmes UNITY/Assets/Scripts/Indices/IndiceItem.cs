using System;
using UnityEngine;

public abstract class IndiceItem : MonoBehaviour
{
    void OnMouseDown() {
        Debug.Log("Tu as cliqué le " + this.GetType());
        GameObject.Find("inventaire" + GetType().ToString().Substring(6)).GetComponent<InventaireItem>().objetTrouve = true;
        this.gameObject.SetActive(false);
    }
}