using System;
using UnityEngine;

public abstract class PoseItems : MonoBehaviour
{
    public bool objetPose = false;

    void OnMouseDown() {
        Debug.Log("Tu veux poser " + this.GetType());
        InventaireItem i = GameObject.Find("inventaire" + GetType().ToString().Substring(4)).GetComponent<InventaireItem>();
        if (i.objetTrouve && i.selected)
        {
            objetPose = true;
            GameObject.Find("MUSIQUES").GetComponent<ConfigMusic>().nbEnigmesResolues ++;
            i.objetTrouve = false;
            i.selected = false;
        }
        else {
            Debug.Log("Tu n'as pas l'objet en main");
        }
    }
}