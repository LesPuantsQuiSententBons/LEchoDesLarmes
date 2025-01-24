using System;
using UnityEngine;

public abstract class PoseItems : MonoBehaviour
{
    public bool objetPose = false;
    private GameObject child;

    void OnMouseDown() {
        Debug.Log("Tu veux poser " + this.GetType());
        InventaireItem i = GameObject.Find("inventaire" + GetType().ToString().Substring(4)).GetComponent<InventaireItem>();
        if (i.objetTrouve && i.selected)
        {
            objetPose = true;
            i.objetTrouve = false;
        }
        else {
            Debug.Log("Tu n'as pas l'objet en main");
        }
    }

    void Start() {
        child = transform.GetChild(0).transform.gameObject;
        child.SetActive(false);
    }

    void Update() {
        if (objetPose) {
            child.SetActive(true);
        } else {
            child.SetActive(false);
        }
    }
}