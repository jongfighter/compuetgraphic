using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class move : MonoBehaviour
{


    public GameObject planet1; // 수성
    float planet1_jugi = 88;
    float planet1_now = 0;

    public GameObject planet2; // 금성
    float planet2_jugi = 255;
    float planet2_now = 0;

    public GameObject planet3; // 지구
    float planet3_jugi = 365;
    float planet3_now = 0;

    public GameObject planet4; // 화성
    float planet4_jugi = 687;
    float planet4_now = 0;

    public GameObject planet5; // 목성
    float planet5_jugi = 4332;
    float planet5_now = 0;

    public GameObject planet6; // 토성
    float planet6_jugi = 10756;
    float planet6_now = 0;

    public GameObject planet7; // 천왕성
    float planet7_jugi = 30707;
    float planet7_now = 0;

    public GameObject planet8; // 해왕성
    float planet8_jugi = 60223;
    float planet8_now = 0;


    // Use this for initialization
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q1 = Input.gyro.attitude;




        //수
        planet1_now = planet1_now + Time.deltaTime;
        planet1.transform.position = new Vector3(3.8f * Convert.ToSingle(Math.Cos(360 * (planet1_now + 10f) / planet1_jugi)), 0/*planet1.GetComponent<Transform>().position.y*/, 3.7f * Convert.ToSingle(Math.Sin(360 * (planet1_now + 10f) / planet1_jugi)));
        if (planet1_now > planet1_jugi)
        {
            planet1_now = 0;
        }

        //금
        planet2_now = planet2_now + Time.deltaTime;
        planet2.transform.position = new Vector3(7.2f * Convert.ToSingle(Math.Cos(360 * (planet2_now + 20f) / planet2_jugi)), 0, 7.2f * Convert.ToSingle(Math.Sin(360 * (planet2_now + 20f) / planet2_jugi)));
        if (planet2_now > planet2_jugi)
        {
            planet2_now = 0;
        }

        //지
        planet3_now = planet3_now + Time.deltaTime;
        planet3.transform.position = new Vector3(10f * Convert.ToSingle(Math.Cos(360 * (planet3_now + 30f) / planet3_jugi)), 0, 9.9f * Convert.ToSingle(Math.Sin(360 * (planet3_now + 30f) / planet3_jugi)));
        if (planet3_now > planet3_jugi)
        {
            planet3_now = 0;
        }

        //화
        planet4_now = planet4_now + Time.deltaTime;
        planet4.transform.position = new Vector3(15.2f * Convert.ToSingle(Math.Cos(360 * (planet4_now + 40f) / planet4_jugi)), 0, 15.1f * Convert.ToSingle(Math.Sin(360 * (planet4_now + 40f) / planet4_jugi)));
        if (planet4_now > planet4_jugi)
        {
            planet4_now = 0;
        }

        //목
        planet5_now = planet5_now + Time.deltaTime;
        planet5.transform.position = new Vector3(52f * Convert.ToSingle(Math.Cos(360 * (planet5_now + 50f) / planet5_jugi)), 0, 51.9f * Convert.ToSingle(Math.Sin(360 * (planet5_now + 50f) / planet5_jugi)));
        if (planet5_now > planet5_jugi)
        {
            planet5_now = 0;
        }

        //토
        planet6_now = planet6_now + Time.deltaTime;
        planet6.transform.position = new Vector3(95.3f * Convert.ToSingle(Math.Cos(360 * (planet6_now + 60f) / planet6_jugi)), 0, 95.2f * Convert.ToSingle(Math.Sin(360 * (planet6_now + 60f) / planet6_jugi)));
        if (planet6_now > planet6_jugi)
        {
            planet6_now = 0;
        }

        //천
        planet7_now = planet7_now + Time.deltaTime;
        planet7.transform.position = new Vector3(191.9f * Convert.ToSingle(Math.Cos(360 * (planet7_now + 70f) / planet7_jugi)), 0, 191.7f * Convert.ToSingle(Math.Sin(360 * (planet7_now + 70f) / planet7_jugi)));
        if (planet7_now > planet7_jugi)
        {
            planet7_now = 0;
        }

        //해
        planet8_now = planet8_now + Time.deltaTime;
        planet8.transform.position = new Vector3(300.6f * Convert.ToSingle(Math.Cos(360 * (planet8_now + 80f) / planet8_jugi)), 0, 300.5f * Convert.ToSingle(Math.Sin(360 * (planet8_now + 80f) / planet8_jugi)));
        if (planet8_now > planet8_jugi)
        {
            planet8_now = 0;
        }
    }


}