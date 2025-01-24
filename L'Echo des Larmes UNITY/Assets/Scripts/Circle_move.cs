using UnityEngine;

public class Circle_move : MonoBehaviour
{
    Vector3 Cercle_position;
    void OnMouseDown()
    {
        //Cercle_position = circle_Start.Rouage[0].transform.position;
        //Cercle_position.x = Cercle_position.y = 0;
        //Debug.Log("Sur Rouage1");
    }

    void OnMouseOver()
    {
        switch(this.name)
        {
            case "Rouage1":
                Debug.Log("Sur Rouage1");
                break;
            case "Rouage2":
                Debug.Log("Sur Rouage2");
                break;
            case "Rouage3":
                Debug.Log("Sur Rouage3");
                break;
            default:
                Debug.Log("Problème");
                break;
        }
    }
}
