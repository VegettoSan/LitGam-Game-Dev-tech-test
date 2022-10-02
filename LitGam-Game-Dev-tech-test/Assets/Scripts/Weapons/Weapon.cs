using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponData Data;
    [SerializeField] Transform Origin;
    [SerializeField] AudioSource Source;

    public int Bullets;
    private float NextShot;
    void Start()
    {
        //Bullets = Data.BulletsMax;
    }

    void Update()
    {
        //if (Bullets > 0)
        //{
            if (Input.GetButton("Fire1"))
            {
                if (Time.time >= NextShot)
                {
                    NextShot = Time.time + 1 / Data.Cadence;

                    Bullets--;
                    Source.PlayOneShot(Data.AudioShot);
                    Rigidbody clone = Instantiate(Data.Projectile, Origin.position, Origin.rotation) as Rigidbody;
                    clone.velocity = Origin.TransformDirection(Vector3.forward * Data.SpeedProjectile);
                }
            }
        //}
    }
}
