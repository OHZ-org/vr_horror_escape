using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProblemUI : MonoBehaviour
{   [SerializeField]
    private GameObject popub;//문제 나오는 ui 창
    [SerializeField]
    private Image pb_image;
    public static ProblemUI instance;
    // Start is called before the first frame update

    private void Awake()//싱글톤 패턴
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
        Debug.Log("팝업 생성");
        popub.SetActive(true);
        setImage(sprite);
    }

    public void ClosePopUp()//문제 창 닫는 함수
    {
        Debug.Log("버튼 누름");
        popub.SetActive(false);
    }

    private void setImage(Sprite sprite)
    {
        pb_image.sprite = sprite;
    }   
}
