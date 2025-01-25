using UnityEngine;
using UnityEngine.Playables;

public class DialogueGerant : MonoBehaviour
{
    public GameObject vinyle, cadeau, fleurs, DialogueBoxFleurs, DialogueBoxVinyle, DialogueBoxCadeau
    , DialogueBoxMonsieur, DialogueBoxMelodie, DialogueBoxServeur, DialogueBoxDebut, MainCamera, RECTANGLENOIR;

    public void PremierMessageTerminé() {
        DialogueBoxDebut.SetActive(false);
        RECTANGLENOIR.SetActive(false);
        MainCamera.GetComponent<PlayableDirector>().Play();
    }

    public void DialogueMonsieurTerminé() {
        DialogueBoxMonsieur.SetActive(false);
        vinyle.gameObject.GetComponent<IndiceVinyle>().clickable = true;
    }

    public void DialogueMelodieTerminé() {
        DialogueBoxMelodie.SetActive(false);
        fleurs.gameObject.GetComponent<IndiceFleurs>().clickable = true;
    }

    public void DialogueServeurTerminé() {
        DialogueBoxServeur.SetActive(false);
        cadeau.gameObject.GetComponent<IndiceCadeau>().clickable = true;
    }

    public void DialogueFleursTerminé() {
        DialogueBoxFleurs.SetActive(false);
    }

    public void DialogueVinyleTerminé() {
        DialogueBoxVinyle.SetActive(false);
    }

    public void DialogueCadeauTerminé() {
        DialogueBoxCadeau.SetActive(false);
    }
}
