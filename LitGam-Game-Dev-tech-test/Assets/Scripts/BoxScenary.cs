using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScenary : MonoBehaviour
{
    private Rigidbody Rig;
    void Start()
    {
        Rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider A)
    {
        /*if (A.CompareTag("Gravity"))
        {
            GravityProjectile Origin = A.GetComponent<GravityProjectile>();
            if (Origin != null)
            {
                Rig.useGravity = false;
                transform.Translate(A.transform.position * Origin.GravityForce, Space.World);
            }
        }*/

        if(A.gameObject.tag == "Gravity")
        {
            GravityProjectile Origin = A.GetComponentInParent<GravityProjectile>();
            Rig.useGravity = false;
            if (Origin != null)
            {
                //transform.Translate(A.transform.position * Origin.GravityForce, Space.World);
                Vector3 direction = transform.position + Origin.transform.position;
                Rig.AddForceAtPosition(direction.normalized * Origin.GravityForce, transform.position);
            }
        }
    }

    private void OnTriggerExit(Collider A)
    {
        if (A.CompareTag("Gravity"))
        {
            GravityProjectile Origin = A.GetComponentInParent<GravityProjectile>();
            Rig.useGravity = true;
            if (Origin != null)
            {
                //rig.transform.Translate(transform.position * Speed, Space.World);
            }
        }
    }
}
