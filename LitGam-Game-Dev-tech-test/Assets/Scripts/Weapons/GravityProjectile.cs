using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityProjectile : MonoBehaviour
{
    [SerializeField] SphereCollider Range;
    public float GravityForce;
    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, Range.radius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(-GravityForce, transform.position, Range.radius);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
