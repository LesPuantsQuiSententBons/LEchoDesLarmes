using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.InputSystem;

public class Circle_move : MonoBehaviour
{
    GameObject Curseur,rouage1,rouage2,rouage3;
    PolygonCollider2D polygon1,polygon2,polygon3;
    void Start()
    {
        Curseur = GameObject.FindGameObjectWithTag("Curseur");
        rouage1 = GameObject.Find("Rouage1").GetComponent<GameObject>();
        rouage2 = GameObject.Find("Rouage2").GetComponent<GameObject>();
        rouage3 = GameObject.Find("Rouage3").GetComponent<GameObject>();
        polygon1 = GameObject.Find("Rouage1").GetComponent<PolygonCollider2D>();
        polygon2 = GameObject.Find("Rouage2").GetComponent<PolygonCollider2D>();
        polygon3 = GameObject.Find("Rouage3").GetComponent<PolygonCollider2D>();
        transform.Rotate(0,0,Random.value * 360);
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
            if((rouage1.transform.rotation.z > 130 && 140 > rouage1.transform.rotation.z)||(rouage1.transform.rotation.z > 130 && 140 > rouage1.transform.rotation.z))
                {
                    if((rouage2.transform.rotation.z > 130 && 140 > rouage2.transform.rotation.z) || (rouage2.transform.rotation.z > 130 && 140 > rouage2.transform.rotation.z))
                        {
                            if((rouage3.transform.rotation.z > -40 && -50 > rouage3.transform.rotation.z) || (rouage3.transform.rotation.z > -40+180 && -50+180 > rouage3.transform.rotation.z))
                            Debug.Log("Enigme Résolu");
                        }
                }
        }
    }
            
}
