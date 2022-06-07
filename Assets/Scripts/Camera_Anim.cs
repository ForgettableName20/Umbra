using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Anim : MonoBehaviour
{
    Animator Cam_Anim;
    int clicked = Animator.StringToHash("clicked");

    // Start is called before the first frame update
    void Start()
    {
        Cam_Anim = GetComponent<Animator>();
    }

    public void PlayCam_Animation()
    {
        Cam_Anim.SetTrigger(clicked);
    }
}
