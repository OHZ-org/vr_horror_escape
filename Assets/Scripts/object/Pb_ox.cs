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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //문제 정답 수 세고 문제 다맞추면 열쇠 생성
    public void judgeAnswer()
    {
        userInput = inputAnswer.text;
        if (checkPB.name == "Pb_book")
        {
            if (userInput == "12")
            {
                Debug.Log("정답" + userInput);
                OKtextChange("정답");
                count1++;
                if(count1 == 1 )
                    Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
            {
                Debug.Log("오답" + userInput);
                Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
                OKtextChange("오답");
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
