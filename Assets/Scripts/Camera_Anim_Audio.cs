using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Anim_Audio : MonoBehaviour
{
    Animator Cam_Anim_Audio;
    int clicked_audio = Animator.StringToHash("clicked_audio");

    // Start is called before the first frame update
    void Start()
    {
        Cam_Anim_Audio = GetComponent<Animator>();
    }

    public void PlayCam_Anim_Audio()
    {
        Cam_Anim_Audio.SetTrigger(clicked_audio);
    }
}

