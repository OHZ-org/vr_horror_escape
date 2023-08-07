using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pb_ox : MonoBehaviour
{
    public InputField inputAnswer;
    public GameObject key;
    public GameObject pbbook;
    private string userInput;

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
        userInput = inputAnswer.text;
        if (userInput == "12")
        {
            Debug.Log("정답"+userInput);
            Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else
        {
            Debug.Log("오답"+userInput);
            Instantiate(key, new Vector3(0,0,0),Quaternion.identity);
        }
    }
}
