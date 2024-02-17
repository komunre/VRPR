using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ActivatableComponent))]
public class SimpleGunComponent : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    private ActivatableComponent activatable;
    private void Start()
    {
        activatable = GetComponent<ActivatableComponent>();
        activatable.activateEvent.AddListener(Shoot);
    }


    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = shootPoint.forward * 100f;
    }
}
