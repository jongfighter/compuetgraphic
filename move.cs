using UnityEngine;
using System.Collections;
using System;

public class move : MonoBehaviour
{
    public GameObject planet1; // 수성
    float planet1_jugi = 500;
    float planet1_now = 0;

    public GameObject planet2; // 금성
    float planet2_jugi = 2;
    float planet2_now = 0;

    public GameObject planet3; // 지구
    float planet3_jugi = 10;
    float planet3_now = 0;

    public GameObject planet4; // 화성
    float planet4_jugi = 10;
    float planet4_now = 0;

    public GameObject planet5; // 목성
    float planet5_jugi = 10;
    float planet5_now = 0;

    public GameObject planet6; // 토성
    float planet6_jugi = 10;
    float planet6_now = 0;

    public GameObject planet7; // 천왕성
    float planet7_jugi = 10;
    float planet7_now = 0;

    public GameObject planet8; // 해왕성
    float planet8_jugi = 10;
    float planet8_now = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        planet1_now = planet1_now + Time.deltaTime;
        planet1.transform.position = new Vector3(13*Convert.ToSingle(Math.Cos(360 * planet1_now / planet1_jugi)), 7 * Convert.ToSingle(Math.Sin(360 * planet1_now / planet1_jugi)), planet1.GetComponent<Transform>().position.z);
        if (planet1_now > planet1_jugi)
        {
            planet1_now = 0;
        }
    }
}
