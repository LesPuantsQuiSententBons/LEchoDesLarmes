using UnityEngine;
using UnityEngine.SceneManagement;

public class GoutteFalling : MonoBehaviour
{
    public GameObject ConfigMusic;

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
            if (ConfigMusic.GetComponent<ConfigMusic>().nbEnigmesResolues == 3) {
                SceneManager.LoadScene(1);
            } else {
                SceneManager.LoadScene(0);
            }
        }
        else 
        {
            this.transform.position += new Vector3(0, -0.00225f, 0); 
            // On part du principe que on descend pour 1min totale, donc 3600 frames à 60fps
            // La goutte commence à y = 3.6f, en descendant à -3.6f, le compte est bon
        }
    }
}
