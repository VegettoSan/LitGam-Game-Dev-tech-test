using UnityEngine;

[CreateAssetMenu (fileName = "New Weapon Data", menuName = "Weapon Data")]
public class WeaponData : ScriptableObject
{
    public string WeaponName;
    [TextArea]
    public string WeaponDescription;
    public Rigidbody Projectile;
    public float SpeedProjectile;
    //public int BulletsMax;
    //public int Damage;
    public float Cadence;
    public AudioClip AudioShot;
}
