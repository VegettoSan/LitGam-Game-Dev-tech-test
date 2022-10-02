using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    enum Type { Collider, Trigger, Time }
    [SerializeField]
    Type DestroyWith;

    [SerializeField] float TimeDelay = 5f;

    void Update()
    {
        if (DestroyWith == Type.Time)
        {
            Destroy(this.gameObject, TimeDelay);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(DestroyWith == Type.Trigger)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (DestroyWith == Type.Collider)
        {
            Destroy(this.gameObject);
        }
    }
}
