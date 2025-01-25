using UnityEngine;

public class PoseVinyle : PoseItems
{
    private GameObject child;

    void Start() {
        child = transform.GetChild(0).transform.gameObject;
        child.SetActive(false);
    }

    void Update() {
        if (objetPose) {
            child.SetActive(true);
            gameObject.SetActive(false);
        } else {
            child.SetActive(false);
            gameObject.SetActive(true);
        }
    }
}
