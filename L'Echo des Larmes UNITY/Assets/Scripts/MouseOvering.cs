using UnityEngine;
using UnityEngine.Rendering;

public class MouseOvering : MonoBehaviour
{
    GameObject Indice;
    SpriteRenderer sprite;
    Color MouseOverColor = Color.yellow;
    Color OriginalColor;
    void Start()
    {
        Indice = GetComponent<GameObject>();
        sprite = GetComponent<SpriteRenderer>();
        OriginalColor = sprite.material.color;
    }
    void OnMouseOver()
    {
        sprite.material.color = MouseOverColor;
        Debug.Log("La souris est dessus");
    }

    void OnMouseExit()
    {
        sprite.material.color = OriginalColor;
    }
}
