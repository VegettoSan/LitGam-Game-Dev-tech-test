using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Weapon : MonoBehaviour
{
    [SerializeField] GameObject PickUpWeapon;
    [SerializeField] Text WeaponName;
    [SerializeField] Text WeaponDescription;
    [SerializeField] GameObject[] Weapons;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ParabolicW") || other.CompareTag("GravityW") || other.CompareTag("RicochetW"))
        {
            PickUpWeapon.SetActive(true);
        }

        if (other.CompareTag("ParabolicW"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                DataUi(Weapons[0].GetComponent<Weapon>().Data);
                Weapons[0].SetActive(true);
                Weapons[1].SetActive(false);
                Weapons[2].SetActive(false);
            }
        }
        if (other.CompareTag("GravityW"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                DataUi(Weapons[1].GetComponent<Weapon>().Data);
                Weapons[0].SetActive(false);
                Weapons[1].SetActive(true);
                Weapons[2].SetActive(false);
            }
        }
        if (other.CompareTag("RicochetW"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                DataUi(Weapons[2].GetComponent<Weapon>().Data);
                Weapons[0].SetActive(false);
                Weapons[1].SetActive(false);
                Weapons[2].SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ParabolicW") || other.CompareTag("GravityW") || other.CompareTag("RicochetW"))
        {
            PickUpWeapon.SetActive(false);
        }
    }
    void DataUi(WeaponData Data)
    {
        WeaponName.text = Data.WeaponName;
        WeaponDescription.text = Data.WeaponDescription;
    }
}
