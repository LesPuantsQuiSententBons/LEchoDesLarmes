using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreditsAnimation : MonoBehaviour
{
    public TextMeshProUGUI textComponent;   
    public float speed = 70f;    

    void Update()
    {
        textComponent.rectTransform.anchoredPosition += Vector2.up * speed * Time.deltaTime;
    }
}
