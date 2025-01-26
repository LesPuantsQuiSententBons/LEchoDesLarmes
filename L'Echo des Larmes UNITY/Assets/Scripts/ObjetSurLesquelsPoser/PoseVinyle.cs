using UnityEngine;

public class PoseVinyle : PoseItems
{
    private GameObject gramophoneEteint;
    private GameObject gramophoneAllume;
    //private bool lancerVinyle = false;

    void Start() {
        gramophoneEteint = transform.GetChild(0).transform.gameObject;
        gramophoneAllume = transform.GetChild(1).transform.gameObject;
        gramophoneAllume.SetActive(false);
    }

    void Update() {
        if (objetPose) {
            /*if (!lancerVinyle) {
                lancerVinyle = true;
                GameObject.Find("MUSIQUES").GetComponent<ConfigMusic>().PlayVinyle();
            }*/
            gramophoneEteint.SetActive(false);
            gramophoneAllume.SetActive(true);
        } else {
            gramophoneEteint.SetActive(true);
            gramophoneAllume.SetActive(false);
        }
    }
}
