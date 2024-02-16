using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuControlComponent : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2f;
    public InputActionProperty menuButton;
    public GameObject menuObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menuButton.action.WasPressedThisFrame())
        {
            ToggleMenu();
        }
        menuObject.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        menuObject.transform.LookAt(head.position);
        menuObject.transform.forward *= -1;
    }

    void ToggleMenu()
    {
        menuObject.SetActive(!menuObject.activeSelf);
    }
}
