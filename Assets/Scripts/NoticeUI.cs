using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

   // ���� �޼��� -> string ���� �Ű� ������ �޾ƿͼ� 2�ʰ� ���
   // ����: _notice.SUB("���ڿ�")
   public void SUB(string message)
    {
        subintext.text = message;
        subbox.SetActive(false);
        StopAllCoroutines();
        StartCoroutine(SUBDelay());
    }

    //�ݺ����� �ʰ� �ϱ� ���� ������ ����
    IEnumerator SUBDelay()
    {
        subbox.SetActive(true);
        subani.SetBool("isOn", true);
        yield return _UIDelay1;

        subani.SetBool("isOn", false);
        yield return _UIDelay2;
        subbox.SetActive(false);
    }

    // '��' ��ư�� ������ ��
    public void OnButtonYesClicked()
    {
        //return true;
    }

    // '�ƴϿ�' ��ư�� ������ ��
    public void OnButtonNoClicked()
    {
        //return false;
    }
}
