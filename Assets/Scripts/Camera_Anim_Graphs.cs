using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Anim_Graphs : MonoBehaviour
{
    Animator Cam_Anim_Graphs;
    int clicked_graphs = Animator.StringToHash("clicked_graphs");

    // Start is called before the first frame update
    void Start()
    {
        Cam_Anim_Graphs = GetComponent<Animator>();
    }

    public void PlayCam_Anim_Graphs()
    {
        Cam_Anim_Graphs.SetTrigger(clicked_graphs);
    }
}
