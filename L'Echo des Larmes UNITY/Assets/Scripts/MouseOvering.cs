using UnityEngine;
using UnityEngine.Rendering;

public class MouseOvering : MonoBehaviour
{
    GameObject Indice;
    GameObject Indice_child;
    SpriteRenderer sprite;
    Color MouseOverColor = Color.yellow;
    Color OriginalColor;
    void Start()
    {
        Indice = GetComponent<GameObject>();
        Indice_child = Indice.transform.GetChild(0).gameObject;
        sprite = GetComponent<SpriteRenderer>();
        OriginalColor = sprite.material.color;
    }
    void OnMouseOver()
    {
        sprite.material.color = MouseOverColor;
        Indice_child.SetActive(true);
        Debug.Log("La souris est dessus");
    }

    void OnMouseExit()
    {
        sprite.material.color = OriginalColor;
        Indice_child.SetActive(false);
    }
}
