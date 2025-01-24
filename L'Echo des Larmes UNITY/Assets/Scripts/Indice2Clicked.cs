using UnityEngine;

public class Indice2Clicked : MonoBehaviour
{
    public int click;

    void OnMouseDown() {
        click++;
        Debug.Log("Tu as cliqué le " + this.GetType());
    }
}
