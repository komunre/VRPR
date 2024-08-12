using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Never destroy: " + this.gameObject.name);
        DontDestroyOnLoad(this.gameObject);
    }
}
