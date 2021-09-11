using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class RealSpeedometer : MonoBehaviour
{
    public float currentSpeed;
    public Text speedText;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        currentSpeed = rb.velocity.magnitude * 2.23694f;

        speedText.text = "Speed: " + currentSpeed.ToString() + "  MPH";
    }
}
