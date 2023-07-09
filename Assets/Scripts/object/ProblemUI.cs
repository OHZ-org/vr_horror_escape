using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProblemUI : MonoBehaviour
{   [SerializeField]
    private GameObject popub;
    private Image pbimage;
    // Start is called before the first frame update
    void Start()
    {
        popub.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ShowPopUp( sprite)
    {
        popub.SetActive(true);
        pbimage = sprite;
    }

    public void ClosePopUp()
    {
        popub.SetActive(false);
    }
}
