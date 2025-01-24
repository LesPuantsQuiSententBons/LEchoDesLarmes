using UnityEngine;

public class InventaireGeneral : MonoBehaviour {
    public void FautEteindre(string type) {
        Debug.Log("Message reçu");
        BroadcastMessage("CasseTOOOI", type);
    }
}