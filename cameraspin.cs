using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;



public class cameraspin : MonoBehaviour
{
    public Text SSB;

    // Use this for initialization
    void Start () {

        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        Invoke("gyroupdate", 0.1f);


    }

    void gyroupdate()
    {

        Quaternion q1 = Input.gyro.attitude;
        Quaternion t = Quaternion.identity;
        t.w = q1.w;
        t.x = q1.x * (-1);
        t.y = q1.y * (-1);
        t.z = q1.z;


        transform.rotation = Quaternion.Euler(280, 90, 0) * t;
    }
}
