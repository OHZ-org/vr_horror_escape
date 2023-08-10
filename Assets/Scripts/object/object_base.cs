using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class object_base : MonoBehaviour
{
    [SerializeField]
    private GameObject popub;//���� ������ ui â
    [SerializeField]
    private Image pb_image;

    private XRGrabInteractable grabInteractable;

    public Sprite pb_sprite;//���� �̹��� ��ü
    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        //ShowPopUp();
    }

    // Update is called once per frame
    void Update()
    {

        if (grabInteractable.isSelected)
        {
            ShowPopUp();
        }
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
