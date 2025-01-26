using UnityEngine;

public class PoseCadeau : PoseItems
{
    private GameObject child;

    void Start() {
        child = transform.GetChild(0).transform.gameObject;
        child.SetActive(false);
    }

    void Update() {
        if (objetPose) {
            child.SetActive(true);
        } else {
            child.SetActive(false);
        }
    }
}
