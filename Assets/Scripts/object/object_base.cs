using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object_base : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    //private ProblemUI pbUI;
    public Sprite pb_sprite;//���� �̹��� ��ü
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

    //���->isgrabbed true->�˾�â ����

    public void showPb()
    {
        Debug.Log("���� �̹��� �ٲ�");
        ProblemUI.instance.ShowPopUp(pb_sprite);//���� �̹��� �ٲ��ִ� �Լ�
    }
 
}
