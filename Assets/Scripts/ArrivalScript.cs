using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivalScript : MonoBehaviour
{
    public GameObject congratsText;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player")) {
            congratsText.SetActive(true);
        }
    }
}
