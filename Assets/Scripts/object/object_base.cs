using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object_base : MonoBehaviour
{
    [SerializeField]
    private GameObject popub;//���� ������ ui â
    [SerializeField]
    private Image pb_image;
    
    private OVRGrabbable ovrGrabbable;

    public Sprite pb_sprite;//���� �̹��� ��ü
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

    //���->isgrabbed true->�˾�â ����


    public void ShowPopUp()
    {
        Debug.Log("�˾� ����");
        popub.SetActive(true);
        setImage(pb_sprite);
    }

    public void ClosePopUp()//���� â �ݴ� �Լ�
    {
        Debug.Log("��ư ����");
        popub.SetActive(false);
    }

    private void setImage(Sprite sprite)
    {
        pb_image.sprite = sprite;
    }

}
