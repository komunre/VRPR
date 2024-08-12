using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    [SerializeField] private bool isMock = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is Device Active: " + XRSettings.isDeviceActive);
        Debug.Log("Used Device: " + XRSettings.loadedDeviceName);
        isMock = XRSettings.loadedDeviceName.Equals("Mock HMD");
        Debug.Log("Is Mock: " + isMock);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset active");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
