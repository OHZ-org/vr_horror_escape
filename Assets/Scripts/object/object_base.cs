using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class object_base : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    private ProblemUI pbUI;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Àâ±â->isgrabbed true->ÆË¾÷Ã¢ ¶ç¿ì±â

    public virtual void isGrabbed()
    {
        pbUI.ShowPopUp(sprite);
    }
 
}
