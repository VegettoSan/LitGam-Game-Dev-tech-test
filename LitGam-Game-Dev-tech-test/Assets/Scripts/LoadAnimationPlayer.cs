using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAnimationPlayer : MonoBehaviour
{
    [SerializeField] private Animator Anim;
    void Start()
    {
        Anim.SetBool(PlayerPrefs.GetString("Animation"), true);
    }
}
