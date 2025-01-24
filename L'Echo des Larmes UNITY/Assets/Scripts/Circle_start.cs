using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class Circle_start : MonoBehaviour
{
    private GameObject Point_pivot,Rouage_principal;
    public GameObject[] Rouage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rouage_principal = GetComponent<GameObject>();
        Rouage = GameObject.FindGameObjectsWithTag("Rouage");
        Point_pivot = GameObject.Find("Point_pivot");
        Debug.Log("Point Pivot trouvé");
        Debug.Log(Rouage.Length + " rouages trouvés");
    }

    void Update()
    {
        //Debug.Log(curseur.MousePosition);
    }
}
