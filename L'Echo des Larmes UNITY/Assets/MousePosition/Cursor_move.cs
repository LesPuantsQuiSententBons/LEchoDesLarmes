using Unity.VisualScripting;
using UnityEngine;
<<<<<<< Updated upstream
=======
using static UnityEngine.Vector3;
>>>>>>> Stashed changes

public class Cursor_move : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject Souris;
    Vector3 MousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream

=======
        MousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
        transform.position = MousePosition;
>>>>>>> Stashed changes
    }
}
