using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject CameraOn;
    public GameObject[] CamerasOff;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            CameraOn.SetActive(true);
            CamerasOff[0].SetActive(false);
            CamerasOff[1].SetActive(false);
        }
    }
}
