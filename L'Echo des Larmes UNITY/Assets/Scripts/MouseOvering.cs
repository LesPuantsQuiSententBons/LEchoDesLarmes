using UnityEngine;
using UnityEngine.Rendering;

public class MouseOvering : MonoBehaviour
{
    GameObject Indice;
    GameObject Point_Exclamation;
    SpriteRenderer sprite;
    Color MouseOverColor = Color.yellow;
    Color OriginalColor;
    void Start()
    {
        Point_Exclamation = GameObject.Find("Point_exclamation");
        Point_Exclamation.SetActive(false);
        Indice = GetComponent<GameObject>();
        sprite = GetComponent<SpriteRenderer>();
        OriginalColor = sprite.material.color;
    }
    void OnMouseOver()
    {
        Point_Exclamation.SetActive(true);
        sprite.material.color = MouseOverColor;
        Debug.Log("La souris est dessus");
    }

    void OnMouseExit()
    {
        Point_Exclamation.SetActive(false);
        sprite.material.color = OriginalColor;
    }
}
