using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConfigMusic : MonoBehaviour
{
    public AudioSource musicTriste1;
    public AudioSource musicTriste2;
    public AudioSource musicTriste3;
    public AudioSource musicTriste4;
    public AudioSource musicVinyle;
    private List<AudioSource> listeMusiques;
    public int nbEnigmesResolues = 0;
    private int oldNbEnigmesResolues = 0;
    private float oldTime = float.PositiveInfinity;

    void Start() {
        listeMusiques = new List<AudioSource>
        {
            musicTriste1,
            musicTriste2,
            musicTriste3,
            musicTriste4
        };
    }

    public void PlayVinyle() {
        foreach (AudioSource item in listeMusiques) {
            item.volume = 0f;
        }
        musicVinyle.gameObject.SetActive(true);
        oldTime = Time.time;
    }

    void Update() {
        if (oldNbEnigmesResolues != nbEnigmesResolues) {
            oldNbEnigmesResolues = nbEnigmesResolues;
            ChangeClip();
        }
        if (oldTime != float.PositiveInfinity) {
            if (oldTime + 15 < Time.time) {
                oldTime = float.PositiveInfinity;
                ChangeClip();
            }
        }
    }

    public void ChangeClip()
    {
        switch (nbEnigmesResolues)
        {
            case 0:
                foreach (AudioSource audioSource in listeMusiques)
                {
                    audioSource.volume = 0f;
                }
                musicTriste1.volume = 1f;
                break;
            case 1:
                foreach (AudioSource audioSource in listeMusiques)
                {
                    audioSource.volume = 0f;
                }
                musicTriste2.volume = 1f;
                break;
            case 2:
                foreach (AudioSource audioSource in listeMusiques)
                {
                    audioSource.volume = 0f;
                }
                musicTriste3.volume = 1f;
                break;
            case 3:
                foreach (AudioSource audioSource in listeMusiques)
                {
                    audioSource.volume = 0f;
                }
                musicTriste4.volume = 1f;
                break;
            default:
                Debug.Log("AAAAAH problème, trop d'énigmes résolues");
                break;
        }
    }
}
