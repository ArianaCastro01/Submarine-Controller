using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderWaterEffect : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        RenderSettings.fog = true;
        Debug.Log("Fog is on");
    }

    private void OnTriggerExit (Collider other)
    {
        RenderSettings.fog = false;
        Debug.Log("Fog is off");
    }
}
