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
    private bool usedkey1=false;
    private bool usedkey2=false;
    private bool usedkey3=false;

    // Start is called before the first frame update
    void Start()
    {
        closepopup();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //���� ���� �� ���� ���� �ٸ��߸� ���� ����
    public void judgeAnswer()
    {
        userInput = inputAnswer.text;
        CheckPB1(userInput);
        CheckPB2(userInput);
        CheckPB3(userInput);

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
    private void CheckPB1(string input)
    {
        if (checkPB.name == "Pb_1_1")
        {
            if (input == "10")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count1++;
                if (count1 == 3 && !usedkey1)
                {
                    Debug.Log("����");
                    key.SetActive(true);
                    usedkey1 = true;
                }
            }
            else
            {
                Debug.Log("����" + input);
                OKtextChange("����");
            }
        }

        if (checkPB.name == "Pb_1_2")
        {
            if (input == "8")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count1++;
                if (count1 == 3 && !usedkey1)
                {
                    Debug.Log("����");
                    key.SetActive(true);
                    usedkey1 = true;
                }
            }
            else
            {
                Debug.Log("����" + input);
                OKtextChange("����");
            }
        }
        if (checkPB.name == "Pb_1_3")
        {
            if (input == "�ⱸ")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count1++;
                if (count1 == 3 && !usedkey1)
                {
                    Debug.Log("����");
                    key.SetActive(true);
                    usedkey1 = true;
                }
            }
            else
            {
                Debug.Log("����" + input);
                OKtextChange("����");
            }
        }
    }

    private void CheckPB2(string input)
    {
        if (checkPB.name == "Pb_2_1")
        {
            if (input == "chair")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
            }
            else
            {
                Debug.Log("����" + input);
                OKtextChange("����");
            }
        }

        if (checkPB.name == "Pb_2_2")
        {
            if (input == "72")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
            }
            else
            {
                Debug.Log("����" + input);
                OKtextChange("����");
            }
        }

        if (checkPB.name == "Pb_2_3")
        {
            if (input == "1341")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
            }
            else
            {
                Debug.Log("����" + input);
                OKtextChange("����");
            }
        }

        if (checkPB.name == "Pb_2_4")
        {
            if (input == "longtimenosee")
            {
                Debug.Log("����" + input);
                OKtextChange("����");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
                else
                {
                    Debug.Log("����" + input);
                    OKtextChange("����");
                }
            }
        }
    }

        private void CheckPB3(string input)
        {
            if (checkPB.name == "Pb_3_1")
            {
                if (input == "954125")
                {
                    Debug.Log("����" + input);
                    OKtextChange("����");
                    count3++;
                    if (count3 == 2 && !usedkey3)
                    {
                        key.SetActive(true);
                        usedkey3 = true;
                    }
                }
                else
                {
                    Debug.Log("����" + input);
                    OKtextChange("����");
                }
            }
            if (checkPB.name == "Pb_3_2")
            {
                if (input == "�ŵ�")
                {
                    Debug.Log("����" + input);
                    OKtextChange("����");
                    count3++;
                    if (count3 == 2 && !usedkey3)
                    {
                        key.SetActive(true);
                        usedkey3 = true;
                    }
                }
                else
                {
                    Debug.Log("����" + input);
                    OKtextChange("����");
                }
            }
        }
    } 

