using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public StartScript startScript;
    void OnTriggerEnter(Collider collider)
    {
        // on vérifie que collider.gameObject est bien la balle
        if(collider.CompareTag("Player")) {
            Destroy(collider.gameObject);
            startScript.ResetBall();
        }
    }
}
