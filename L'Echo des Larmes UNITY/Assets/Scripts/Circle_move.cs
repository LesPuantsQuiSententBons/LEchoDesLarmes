using System.Transactions;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Circle_move : MonoBehaviour
{
    GameObject Curseur;
    PolygonCollider2D polygon1,polygon2,polygon3;
    void Start()
    {
        Curseur = GameObject.FindGameObjectWithTag("Curseur");
        polygon1 = GameObject.Find("Rouage1").GetComponent<PolygonCollider2D>();
        polygon2 = GameObject.Find("Rouage2").GetComponent<PolygonCollider2D>();
        polygon3 = GameObject.Find("Rouage3").GetComponent<PolygonCollider2D>();
    }
    void OnMouseOver()
    {
        Vector3 Cursor_look;
        float Angle;

        if(Input.GetMouseButton(0))
        {
            switch(name)
            {
            case "Rouage1":
                polygon2.enabled = false;
                polygon3.enabled = false;
                Cursor_look = transform.InverseTransformDirection(Curseur.transform.position);
                Angle = Mathf.Atan2(Cursor_look.y,Cursor_look.x) * Mathf.Rad2Deg - 90;
                transform.Rotate(0,0,Angle);
                break;
            case "Rouage2":
                polygon1.enabled = false;
                polygon3.enabled = false;
                Cursor_look = transform.InverseTransformDirection(Curseur.transform.position);
                Angle = Mathf.Atan2(Cursor_look.y,Cursor_look.x) * Mathf.Rad2Deg - 90;
                transform.Rotate(0,0,Angle);
                break;
            case "Rouage3":
                polygon1.enabled = false;
                polygon2.enabled = false;
                Cursor_look = transform.InverseTransformDirection(Curseur.transform.position);
                Angle = Mathf.Atan2(Cursor_look.y,Cursor_look.x) * Mathf.Rad2Deg - 90;
                transform.Rotate(0,0,Angle);
                break;
            default:
                    Debug.Log("Y'A PAS D'AUTRES ROUAGES CHEF");
                    break;
            }
        }
        else
        {
            polygon1.enabled = true;
            polygon2.enabled = true;
            polygon3.enabled = true;
        }
    }
            
}
