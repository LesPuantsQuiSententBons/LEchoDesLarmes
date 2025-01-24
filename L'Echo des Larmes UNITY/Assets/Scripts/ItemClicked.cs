using UnityEngine;

public class ItemClicked : MonoBehaviour
{
    public int click;

    void OnMouseDown() {
        click++;
        Debug.Log("Tu as cliqué");
    }
}
