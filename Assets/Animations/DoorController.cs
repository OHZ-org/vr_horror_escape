using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Animator _doorAnimator;



    public bool IsOpen = false;


    private string paramOpen = "open";

    public void Open()
    {
        IsOpen = true;
        _doorAnimator.SetBool(paramOpen, IsOpen);
    }

    public void Close()
    {
        IsOpen = false;
        _doorAnimator.SetBool(paramOpen, IsOpen);

    }

    public void Toggle()
    {
        IsOpen = !IsOpen;
        _doorAnimator.SetBool(paramOpen, IsOpen);

    }


}
