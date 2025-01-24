using System;
using UnityEngine;

public class RideauGauche : MonoBehaviour
{
    public Animator cameraAnimator;

    void OnMouseDown() {
        Debug.Log("RideauGauche Clické");
        
        if (cameraAnimator.GetBool("EtreADroite")) {
            cameraAnimator.SetBool("EtreADroite", false);

        } else if (!cameraAnimator.GetBool("EtreAGauche")) {
            cameraAnimator.SetBool("EtreAGauche", true);
        }
    }
}