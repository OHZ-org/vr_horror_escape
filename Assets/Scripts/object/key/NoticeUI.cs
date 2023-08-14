using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;
using System.Reflection;

public class NoticeUI : MonoBehaviour
{
    public int UINumber;

    [Header("SubNotice")]
    public GameObject subbox;
    public TMP_Text subintext;
    public Animator subani;

    private WaitForSeconds _UIDelay1 = new WaitForSeconds(2.0f);
    private WaitForSeconds _UIDelay2 = new WaitForSeconds(0.3f);

    public Button buttonYes;
    public Button buttonNo;
    KeyCollisionAll keyCollision;

    string keyName;

    void Start()
    {
        subbox.SetActive(false);
        buttonYes.GetComponentInChildren<Button>();
        keyCollision = FindObjectOfType<KeyCollisionAll>();
    }

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }

   // 서브 메세지 -> string 값을 매개 변수로 받아와서 2초간 출력
   // 사용법: _notice.SUB("문자열")
   public void SUB(string message, Vector3 pos, string keyName)
   {
        this.keyName = keyName;

        subintext.text = message;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SUBDelay());

        pos.z += 0.2f;
        transform.position = pos;
   }

    //반복되지 않게 하기 위해 딜레이 설정
    IEnumerator SUBDelay()
    {
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;

        //subani.SetBool("isOn", false);
        //yield return _UIDelay2;
        //subbox.SetActive(false);
    }

    // '예' 버튼이 눌렸을 때
    public void OnButtonYesClicked()
    {
        Debug.Log("OkButton Clicked");
        Debug.Log(keyName);
        //keyCollision.Check(UINumber); // 맞는 열쇠인지 체크하는 함수 호출
        StartCoroutine(HideUI());
    }

    // '아니오' 버튼이 눌렸을 때
    public void OnButtonNoClicked()
    {
        StartCoroutine(HideUI());
    }

    IEnumerator HideUI()
    {
        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        subbox.SetActive(false);
    }
}
