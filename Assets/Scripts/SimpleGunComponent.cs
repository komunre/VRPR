using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActivatableComponent))]
public class SimpleGunComponent : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    private ActivatableComponent activatable;
    private float bulletSpeed = 10f;
    private void Start()
    {
        activatable = GetComponent<ActivatableComponent>();
        activatable.activateEvent.AddListener(Shoot);
    }


    public void Shoot(ActivateEventArgs args)
    {
        var bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = shootPoint.forward * bulletSpeed;
        Destroy(bullet, 30);
    }
}
