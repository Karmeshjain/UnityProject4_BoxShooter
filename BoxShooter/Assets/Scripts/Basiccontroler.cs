using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basiccontroler : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Horizontal input =" + Input.GetAxis("Horizontal"));
        
    }
}
