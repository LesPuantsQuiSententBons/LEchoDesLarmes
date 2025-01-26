using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public abstract class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string [] lines;
    public float textSpeed = 0.9f;

    protected int index;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
               NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

public void StartDialogue()
{
index = 0;
StartCoroutine(TypeLine());

}
protected IEnumerator TypeLine()
{
    foreach(char c in lines[index].ToCharArray())
    {
        textComponent.text += c;
        yield return new WaitForSeconds(textSpeed);
    }
}
abstract public void NextLine();


}
