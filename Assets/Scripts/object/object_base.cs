using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object_base : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    //private ProblemUI pbUI;
    public Sprite pb_sprite;//문제 이미지 객체
    // Start is called before the first frame update
    void Start()
    {
        //showPb();
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrabbable.isGrabbed)
        {
            showPb();
        }

    }

    //잡기->isgrabbed true->팝업창 띄우기

    public void showPb()
    {
        Debug.Log("문제 이미지 바뀜");
        ProblemUI.instance.ShowPopUp(pb_sprite);//문제 이미지 바꿔주는 함수
    }
 
}
