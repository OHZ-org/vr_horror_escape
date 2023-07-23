using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;

public class NoticeUI : MonoBehaviour
{
    [Header("SubNotice")]
    public GameObject subbox;
    public TMP_Text subintext;
    public Animator subani;

    private WaitForSeconds _UIDelay1 = new WaitForSeconds(2.0f);
    private WaitForSeconds _UIDelay2 = new WaitForSeconds(0.3f);

    public Button buttonYes;
    public Button buttonNo;

    void Start()
    {
        subbox.SetActive(false);    
    }

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }

   // ���� �޼��� -> string ���� �Ű� ������ �޾ƿͼ� 2�ʰ� ���
   // ����: _notice.SUB("���ڿ�")
   public void SUB(string message, Vector3 pos)
   {
        subintext.text = message;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SUBDelay());

        pos.z += 0.2f;
        transform.position = pos;
   }

    //�ݺ����� �ʰ� �ϱ� ���� ������ ����
    IEnumerator SUBDelay()
    {
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;

        //subani.SetBool("isOn", false);
        //yield return _UIDelay2;
        //subbox.SetActive(false);
    }

    // '��' ��ư�� ������ ��
    public void OnButtonYesClicked()
    {
        StartCoroutine(HideUI());
    }

    // '�ƴϿ�' ��ư�� ������ ��
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
