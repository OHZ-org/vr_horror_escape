using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pb_ox : MonoBehaviour
{
    public InputField inputAnswer;
    public GameObject key;
    public GameObject pbbook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void judgeAnswer()
    {
        if (inputAnswer.text == "12")
        {
            Debug.Log("정답");
            Instantiate(key, pbbook.transform);
        }
        else
        {
            Debug.Log("오답");
        }
    }
}
