using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProblemUI : MonoBehaviour
{   [SerializeField]
    private GameObject popub;//���� ������ ui â
    [SerializeField]
    private Image pb_image;
    public static ProblemUI instance;
    // Start is called before the first frame update

    private void Awake()//�̱��� ����
    {
        if (ProblemUI.instance == null)
        {
            ProblemUI.instance = this;
        }
    }
    void Start()
    {
        popub.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ShowPopUp(Sprite sprite)
    {
        Debug.Log("�˾� ����");
        popub.SetActive(true);
        setImage(sprite);
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
