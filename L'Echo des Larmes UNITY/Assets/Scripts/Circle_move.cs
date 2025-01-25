using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.InputSystem;

public class Circle_move : MonoBehaviour
{
    GameObject Curseur;
    public GameObject rouage1,rouage2,rouage3;
    PolygonCollider2D polygon1,polygon2,polygon3;
    void Start()
    {
        Curseur = GameObject.FindGameObjectWithTag("Curseur");
        polygon1 = GameObject.Find("Rouage1").GetComponent<PolygonCollider2D>();
        polygon2 = GameObject.Find("Rouage2").GetComponent<PolygonCollider2D>();
        polygon3 = GameObject.Find("Rouage3").GetComponent<PolygonCollider2D>();
        transform.Rotate(0,0,Random.value * 360);
    }

    void Update()
    {
       /* if(isRouage1True)
            Debug.Log("Grosse roue résolue");
        if(rouage1.transform.rotation.z > 120)
            Debug.Log("Au-dessus de 120");*/
        if(rouage1.transform.rotation.z > rouage1.transform.rotation.z+0.1*0.92)
            Debug.Log("Rouage 1 supérieur");
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
            Debug.Log("Rouage 1 en z est : " + rouage1.transform.rotation.z);
            Debug.Log("Rouage 2 en z est : " + rouage2.transform.rotation.z);
            Debug.Log("Rouage 3 en z est : " + rouage3.transform.rotation.z);
            if(-0.85 < rouage1.transform.rotation.z && rouage1.transform.rotation.z < -0.95)
                {
                    Debug.Log("Bonne réponse");
                    if(-0.85 < rouage2.transform.rotation.z && rouage2.transform.rotation.z < -0.95)
                        {
                            Debug.Log("2 Bonne réponse");
                            if(-50 < rouage3.transform.rotation.z && rouage3.transform.rotation.z < -40)
                            Debug.Log("Enigme Résolu");
                        }
                }
        }
    }
            
}
