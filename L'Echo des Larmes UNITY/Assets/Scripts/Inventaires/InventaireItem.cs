using System;
using UnityEngine;

public abstract class InventaireItem : MonoBehaviour
{
    protected SpriteRenderer sprite;
    protected GameObject child;
    public bool objetTrouve = false;
    public bool selected = false;

    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        child = this.transform.GetChild(0).gameObject;
    }

    void OnMouseDown() {
        Debug.Log("Tu as cliqué le " + this.GetType());
        if (child.activeInHierarchy)
        {
            selected = true;
            SendMessageUpwards("FautEteindre", GetType().ToString());
        }
    } 

    public void CasseTOOOI(string type) {
        if (!type.Equals(GetType().ToString())) 
        {
            Debug.Log(GetType() + " n'est plus sélectionné");
            selected = false;
        }
    }

    public void trouve() {
        objetTrouve = true;
        Debug.Log(GetType() + " a été récupéré");
        Color c = sprite.material.color;
        sprite.material.color = new Color(c.r, c.g, c.b, 1f);
        child.SetActive(true);
    }

    void Update() {
        if (selected)
        {
            transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
        }
        else 
        {
            transform.localScale = new Vector3(4.347826f, 4.347826f, 4.347826f);
        }
        if (objetTrouve) 
        {
            Color c = sprite.material.color;
            sprite.material.color = new Color(c.r, c.g, c.b, 1f);
            child.SetActive(true);
        }
        else 
        {
            Color c = sprite.material.color;
            sprite.material.color = new Color(c.r, c.g, c.b, 0.5f);
            child.SetActive(false);
        }
    }
}