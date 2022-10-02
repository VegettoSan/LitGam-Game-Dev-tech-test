using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator Anim;

    private string AnimationName;
    void Start()
    {
        PlayerPrefs.DeleteKey("Animation");

        if(AnimationName == "")
        {
            Anim.SetBool("HipHop", false);
            Anim.SetBool("Macarena", false);
            Anim.SetBool("House", false);
        }
        else if(AnimationName != "")
        {
            Anim.SetBool(AnimationName, true);
        }
    }

    public void HipHop()
    {
        AnimationName = "HipHop";

        Anim.SetBool("HipHop", true);
        Anim.SetBool("Macarena", false);
        Anim.SetBool("House", false);
    }
    public void Macarena()
    {
        AnimationName = "Macarena";

        Anim.SetBool("HipHop", false);
        Anim.SetBool("Macarena", true);
        Anim.SetBool("House", false);
    }
    public void House()
    {
        AnimationName = "House";

        Anim.SetBool("HipHop", false);
        Anim.SetBool("Macarena", false);
        Anim.SetBool("House", true);
    }

    public void SaveAnimation()
    {
        string[] s = { "HipHop", "Macarena", "House" };
        int i = Random.Range(0, s.Length);

        if(AnimationName != "")
        {
            PlayerPrefs.SetString("Animation", AnimationName);
        }
        else if (AnimationName == "")
        {
            AnimationName = s[i];
            Anim.SetBool(s[i], true);
        }
    }
}
