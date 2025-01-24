using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Vector3;

public class Cursor_move : MonoBehaviour
{
    private Camera mainCamera;
    private GameObject Souris, Objet_indice;

    Vector3 MousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
        Souris = GetComponent<GameObject>();
        Objet_indice = GameObject.Find("Square");
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
        transform.position = MousePosition;
    }
}
