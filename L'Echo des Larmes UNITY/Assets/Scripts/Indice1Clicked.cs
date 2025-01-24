using UnityEngine;

public class Indice1Clicked : MonoBehaviour
{
    public int click;

    void OnMouseDown() {
        click++;
        Debug.Log("Tu as cliqué le " + this.GetType());
    }
}
