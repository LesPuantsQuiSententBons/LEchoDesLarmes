using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Vector3;

public class Cursor_move : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private GameObject Souris;
    [SerializeField] private BoxCollider2D Objet_collider;

    Vector3 MousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Souris = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
        transform.position = MousePosition;
    }
}
