using System;
using UnityEngine;

public class RideauDroit : MonoBehaviour
{
    public Animator cameraAnimator;

    void OnMouseDown() {
        Debug.Log("RideauDroit Clické");
        
        if (cameraAnimator.GetBool("EtreAGauche")) {
            cameraAnimator.SetBool("EtreAGauche", false);

        } else if (!cameraAnimator.GetBool("EtreADroite")) {
            cameraAnimator.SetBool("EtreADroite", true);
        }
    }
}