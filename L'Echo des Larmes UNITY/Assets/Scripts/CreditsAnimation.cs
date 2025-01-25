using UnityEngine;
using UnityEngine.UI;

public class CreditsAnimation : MonoBehaviour
{
    public Text textComponent;   
    public float speed = 50f;    

    void Update()
    {
        textComponent.rectTransform.anchoredPosition += Vector2.up * speed * Time.deltaTime;
    }
}
