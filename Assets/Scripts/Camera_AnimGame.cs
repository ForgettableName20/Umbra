using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_AnimGame : MonoBehaviour
{
    Animator Cam_Anim_Game;
    int clicked_game = Animator.StringToHash("clicked_game");

    // Start is called before the first frame update
    void Start()
    {
        Cam_Anim_Game = GetComponent<Animator>();
    }

    public void PlayCam_Anim_Game()
    {
        Cam_Anim_Game.SetTrigger(clicked_game);
    }
}
