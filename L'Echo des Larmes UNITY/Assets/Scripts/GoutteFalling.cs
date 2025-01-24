using UnityEngine;

public class GoutteFalling : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, -0.001f, 0); 
        // On part du principe que on descend pour 2min totale, donc 7200 frames à 60fps
        // La goutte commence à y = 3.6f, en descendant à -3.6f, le compte est bon

        if (this.transform.position.y < -3.6f)
        {
            Debug.Log("JE QUITTE MA FEMME ET MA FAMILLE");
            Application.Quit();
        }
    }
}
