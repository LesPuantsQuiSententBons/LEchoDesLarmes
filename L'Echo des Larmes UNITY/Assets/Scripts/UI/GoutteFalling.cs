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
        if (this.transform.position.y < -4.2f)
        {
            Debug.Log("JE QUITTE MA FEMME ET MA FAMILLE");
            Application.Quit();
        }
        else 
        {
            this.transform.position += new Vector3(0, -0.00225f, 0); 
            // On part du principe que on descend pour 1min totale, donc 3600 frames à 60fps
            // La goutte commence à y = 3.6f, en descendant à -3.6f, le compte est bon
        }
    }
}
