using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pb_ox : MonoBehaviour
{
    public InputField inputAnswer; // 플레이어가 쓰는 정답
    public GameObject key; // 문제들을 다 풀면 나오는 보상
    public GameObject pbbook;
    public GameObject okPopup; // 문제가 정답인지 아닌지 알려주는 ui
    public Text okText; // 문제 정답 오답쓰는 텍스트
    public GameObject checkPB; // 무슨 문제인지 체크하기 위한 객체
    private string userInput;
    private static int count1;// 1반 문제 정답수 
    private static int count2;// 2반 문제 정답수 
    private static int count3;// 미술실 문제 정답수 
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
    //문제 정답 수 세고 문제 다맞추면 열쇠 생성
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
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count1++;
                if (count1 == 3 && !usedkey1)
                {
                    Debug.Log("열쇠");
                    key.SetActive(true);
                    usedkey1 = true;
                }
            }
            else
            {
                Debug.Log("오답" + input);
                OKtextChange("오답");
            }
        }

        if (checkPB.name == "Pb_1_2")
        {
            if (input == "8")
            {
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count1++;
                if (count1 == 3 && !usedkey1)
                {
                    Debug.Log("열쇠");
                    key.SetActive(true);
                    usedkey1 = true;
                }
            }
            else
            {
                Debug.Log("오답" + input);
                OKtextChange("오답");
            }
        }
        if (checkPB.name == "Pb_1_3")
        {
            if (input == "출구")
            {
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count1++;
                if (count1 == 3 && !usedkey1)
                {
                    Debug.Log("열쇠");
                    key.SetActive(true);
                    usedkey1 = true;
                }
            }
            else
            {
                Debug.Log("오답" + input);
                OKtextChange("오답");
            }
        }
    }

    private void CheckPB2(string input)
    {
        if (checkPB.name == "Pb_2_1")
        {
            if (input == "chair")
            {
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
            }
            else
            {
                Debug.Log("오답" + input);
                OKtextChange("오답");
            }
        }

        if (checkPB.name == "Pb_2_2")
        {
            if (input == "72")
            {
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
            }
            else
            {
                Debug.Log("오답" + input);
                OKtextChange("오답");
            }
        }

        if (checkPB.name == "Pb_2_3")
        {
            if (input == "1341")
            {
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
            }
            else
            {
                Debug.Log("오답" + input);
                OKtextChange("오답");
            }
        }

        if (checkPB.name == "Pb_2_4")
        {
            if (input == "longtimenosee")
            {
                Debug.Log("정답" + input);
                OKtextChange("정답");
                count2++;
                if (count2 == 4 && !usedkey2)
                {
                    key.SetActive(true);
                    usedkey2 = true;
                }
                else
                {
                    Debug.Log("오답" + input);
                    OKtextChange("오답");
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
                    Debug.Log("정답" + input);
                    OKtextChange("정답");
                    count3++;
                    if (count3 == 2 && !usedkey3)
                    {
                        key.SetActive(true);
                        usedkey3 = true;
                    }
                }
                else
                {
                    Debug.Log("오답" + input);
                    OKtextChange("오답");
                }
            }
            if (checkPB.name == "Pb_3_2")
            {
                if (input == "매듭")
                {
                    Debug.Log("정답" + input);
                    OKtextChange("정답");
                    count3++;
                    if (count3 == 2 && !usedkey3)
                    {
                        key.SetActive(true);
                        usedkey3 = true;
                    }
                }
                else
                {
                    Debug.Log("오답" + input);
                    OKtextChange("오답");
                }
            }
        }
    } 

