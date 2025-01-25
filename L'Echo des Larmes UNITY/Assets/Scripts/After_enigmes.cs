using UnityEngine;

public class After_enigmes : MonoBehaviour
{
    SpriteRenderer Sprite;
    Color Sprite_color = new Color(255,255,0,1f);
    void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("MUSIQUES").GetComponent<ConfigMusic>().nbEnigmesResolues == 3)
            Sprite.material.color = Sprite_color;
    }
}
