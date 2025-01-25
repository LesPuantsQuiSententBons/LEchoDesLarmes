using UnityEngine;

public class PoseVinyle : PoseItems
{
    private GameObject gramophoneEteint;
    private GameObject gramophoneAllume;

    void Start() {
        gramophoneEteint = transform.GetChild(0).transform.gameObject;
        gramophoneAllume = transform.GetChild(1).transform.gameObject;
        gramophoneAllume.SetActive(false);
    }

    void Update() {
        if (objetPose) {
            gramophoneEteint.SetActive(false);
            gramophoneAllume.SetActive(true);
        } else {
            gramophoneEteint.SetActive(true);
            gramophoneAllume.SetActive(false);
        }
    }
}
