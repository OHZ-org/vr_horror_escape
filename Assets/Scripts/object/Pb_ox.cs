using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pb_ox : MonoBehaviour
{
    public InputField inputAnswer; // �÷��̾ ���� ����
    public GameObject key; // �������� �� Ǯ�� ������ ����
    public GameObject pbbook; 
    public GameObject okPopup; // ������ �������� �ƴ��� �˷��ִ� ui
    public Text okText; // ���� ���� ���侲�� �ؽ�Ʈ
    public GameObject checkPB; // ���� �������� üũ�ϱ� ���� ��ü
    private string userInput;
    private static int count1;// 1�� ���� ����� 
    private static int count2;// 2�� ���� ����� 
    private static int count3;// �̼��� ���� ����� 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //���� ���� �� ���� ���� �ٸ��߸� ���� ����
    public void judgeAnswer()
    {
        userInput = inputAnswer.text;
        if (checkPB.name == "Pb_book")
        {
            if (userInput == "12")
            {
                Debug.Log("����" + userInput);
                OKtextChange("����");
                count1++;
                if(count1 == 1 )
                    Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
            {
                Debug.Log("����" + userInput);
                Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
                OKtextChange("����");
            }
        }
    }
    private void OKtextChange(string ok)
    {
        okPopup.SetActive(true);
        okText.text = ok;
    }
    public void closepopup()
    {
        okPopup.SetActive(false);
    }
}
