using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basicmover : MonoBehaviour
{

    public float spinspeed = 180.0f;
    public float motionmagnitude = 0.1f;
    public bool dospin = true;
    public bool domotion = true;
    // Update is called once per frame
    void Update()
    {
        if(dospin)
        gameObject.transform.Rotate(spinspeed * Time.deltaTime * Vector3.up);
        if(domotion)
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad)*motionmagnitude);
        

    }
}
