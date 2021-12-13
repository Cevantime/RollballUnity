using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGround : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 20;
    [SerializeField] private float angleMax = 45;

    private float angleTilt;
    private float angleRotation;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        float oldTilt = angleTilt;
        // inputH est compris entre -1 et 1 (-1 pour la gauche et 1 pour la droite)
        float inputH = Input.GetAxis("Horizontal");
        float tilt = inputH * Time.deltaTime * rotateSpeed;
        angleTilt = Mathf.Clamp(oldTilt + tilt, -angleMax, angleMax);
        transform.Rotate(Vector3.back * (angleTilt - oldTilt));

        float oldRotation = angleRotation;
        float inputV = Input.GetAxis("Vertical");
        float rotation = inputV * Time.deltaTime * rotateSpeed;
        angleRotation = Mathf.Clamp(oldRotation + rotation, -angleMax, angleMax);
        transform.Rotate(Vector3.right * (angleRotation - oldRotation));

        Quaternion r = transform.rotation;
        r.y = 0;
        transform.rotation = r;
    }
}
