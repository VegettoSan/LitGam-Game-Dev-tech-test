using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateView : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private Transform Player;

    private void Start()
    {
        Rotate(0f);
    }

    public void Rotate(float value)
    {
        Player.rotation = Quaternion.Euler(0f, -value * 180, 0f);
    }
}
