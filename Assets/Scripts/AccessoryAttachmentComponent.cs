using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessoryAttachmentComponent : MonoBehaviour
{
    protected GameObject attachedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attach(GameObject obj)
    {
        attachedObject = obj;
        obj.transform.SetParent(transform, false);
        obj.transform.eulerAngles = new Vector3(0, 0, 180);
    }
    public void Detach(GameObject obj)
    {
        attachedObject = null;
        obj.transform.SetParent(null, true);
    }
}
