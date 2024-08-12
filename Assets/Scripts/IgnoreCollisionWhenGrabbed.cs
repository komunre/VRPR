using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class IgnoreCollisionWhenGrabbed : XRGrabInteractable
{
    private int handLayer;
    private int moveableLayer;
    [SerializeField] private List<Collider> colliders;

    [SerializeField] private BoxCollider leftHand;
    [SerializeField] private BoxCollider rightHand;

    // Start is called before the first frame update
    void Start()
    {
        handLayer = LayerMask.GetMask("Hand");
        moveableLayer = LayerMask.GetMask("Hand Movable");
    }

    protected override void Grab()
    {
        base.Grab();
        SetIgnore(true);
    }

    protected override void Drop()
    {
        base.Drop();
        SetIgnore(false);
    }

    public void SetIgnore(bool value)
    {
        Debug.Log("Changing ignore state of " + this.gameObject.name);
        //Physics.IgnoreLayerCollision(handLayer, moveableLayer, value);
        for (int i = 0; i < colliders.Count; i++) {
            Physics.IgnoreCollision(colliders.ElementAt(i), leftHand, value);
            Physics.IgnoreCollision(colliders.ElementAt(i), rightHand, value);
        }
    }
}
