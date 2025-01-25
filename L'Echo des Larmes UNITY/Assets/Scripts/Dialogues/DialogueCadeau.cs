using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class DialogueCadeau : Dialogue
{

public override void NextLine()
  {
    if (index < lines.Length - 1)
    {
        index++;
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
    }
    else
    {
      SendMessageUpwards("DialogueCadeauTerminé");
    }
  }

}