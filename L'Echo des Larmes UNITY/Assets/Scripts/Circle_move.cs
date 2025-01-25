using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.InputSystem;

public class Circle_move : MonoBehaviour
{
    GameObject Curseur;
    public GameObject rouage1,rouage2,rouage3;
    PolygonCollider2D polygon1,polygon2,polygon3;
    bool isRouage1True,isRouage2True,isRouage3True;
    void Start()
    {
        Curseur = GameObject.FindGameObjectWithTag("Curseur");
        polygon1 = GameObject.Find("Rouage1").GetComponent<PolygonCollider2D>();
        polygon2 = GameObject.Find("Rouage2").GetComponent<PolygonCollider2D>();
        polygon3 = GameObject.Find("Rouage3").GetComponent<PolygonCollider2D>();
        transform.Rotate(0,0,Random.value * 360);
        isRouage1True = isRouage2True = isRouage3True = false;
    }

    void Update()
    {    
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
            if(rouage1.transform.eulerAngles.z > 130 && rouage1.transform.eulerAngles.z < 140)
                {isRouage1True = true;}
            else
                {Debug.Log("Rouage1 : " + rouage1.transform.eulerAngles.z);
                isRouage1True = false;}
            if(rouage2.transform.eulerAngles.z > 130 && rouage2.transform.eulerAngles.z < 140)
                {isRouage2True = true;}
            else
               {Debug.Log("Rouage2 : " + rouage2.transform.eulerAngles.z);
                isRouage2True = false;}
            if((rouage3.transform.eulerAngles.z < -40+360 && rouage3.transform.eulerAngles.z > -50+360) || (rouage3.transform.eulerAngles.z < -40 && rouage3.transform.eulerAngles.z > -50))
                {isRouage3True = true;}
            else
                {Debug.Log("Rouage3 : " + rouage3.transform.eulerAngles.z);
                isRouage3True = false;}
        }
        Debug.Log("Rouage1 : " + isRouage1True);
        Debug.Log("Rouage2 : " + isRouage2True);
        Debug.Log("Rouage3 : " + isRouage3True);
        if(isRouage1True && isRouage2True && isRouage3True)
            Debug.Log("Game Finish");
    }
            
}
