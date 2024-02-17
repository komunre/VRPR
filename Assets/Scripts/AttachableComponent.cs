using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachableComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == null || other.gameObject == null) return;
        if (other.gameObject.TryGetComponent<AccessoryAttachmentComponent>(out var att))
        {
            att.Attach(gameObject);
        }
    }
}
