using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class EnableOrDisableVr : MonoBehaviour
{

    public bool vrStatus;

    void Awake(){

        if(vrStatus == true){
            UnityEngine.XR.XRSettings.enabled = true;
        } else {
            UnityEngine.XR.XRSettings.enabled = false;
            Camera.main.GetComponent<Transform>().localRotation = UnityEngine.XR.InputTracking.GetLocalRotation(XRNode.CenterEye);
        }

        StartCoroutine(LoadDevice("Cardboard"));
    }

    IEnumerator LoadDevice(string deviceName)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(deviceName);
        yield return null;
        if(vrStatus == true){
            UnityEngine.XR.XRSettings.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (vrStatus == false){
            Camera.main.GetComponent<Transform>().localRotation = UnityEngine.XR.InputTracking.GetLocalRotation(XRNode.CenterEye);
        }
    }
}
