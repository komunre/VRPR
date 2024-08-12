using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    public Transform returnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == null) return;

        var obj = collision.gameObject;
        if (obj.CompareTag("Gameplay Object"))
        {
            obj.transform.position = returnPosition.position;
        }

        if (obj.TryGetComponent<Rigidbody>(out var rigidbody))
        {
            rigidbody.velocity = Vector3.zero;
        }
    }
}
