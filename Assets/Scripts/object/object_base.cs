using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object_base : MonoBehaviour
{
    [SerializeField]
    private GameObject popub;//문제 나오는 ui 창
    [SerializeField]
    private Image pb_image;
    
    private OVRGrabbable ovrGrabbable;

    public Sprite pb_sprite;//문제 이미지 객체
    // Start is called before the first frame update
    void Start()
    {
        ShowPopUp();
    }

    // Update is called once per frame
    void Update()
    {
        //if (ovrGrabbable.isGrabbed)
        //{
        //    showPb();
        //}
       

    }

    //잡기->isgrabbed true->팝업창 띄우기


    public void ShowPopUp()
    {
        Debug.Log("팝업 생성");
        popub.SetActive(true);
        setImage(pb_sprite);
    }

    public void ClosePopUp()//문제 창 닫는 함수
    {
        Debug.Log("버튼 누름");
        popub.SetActive(false);
    }

    private void setImage(Sprite sprite)
    {
        pb_image.sprite = sprite;
    }

}
