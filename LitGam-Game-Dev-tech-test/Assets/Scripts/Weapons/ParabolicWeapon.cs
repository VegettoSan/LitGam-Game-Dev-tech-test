using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicWeapon : MonoBehaviour
{
    [SerializeField] private WeaponData Data;
    [SerializeField] Transform Origin;
    private int Bullets;
    void Start()
    {
        Bullets = Data.BulletsMax;
    }

    void Update()
    {
        if(Bullets > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log("Fire");
                Rigidbody clone = Instantiate(Data.Projectile, Origin.position, Origin.rotation) as Rigidbody;
                clone.velocity = Origin.TransformDirection(Vector3.forward * Data.SpeedProjectile);
            }
        }
    }
}
