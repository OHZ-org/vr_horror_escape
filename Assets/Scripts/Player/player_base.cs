using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_base : MonoBehaviour
{
    public string moveAxisName = "Vertical"; // 앞뒤 움직임을 위한 입력축 이름
    public string rotateAxisName = "Horizontal"; // 좌우 회전을 위한 입력축 이름

    public float move { get; private set; }
    public float rotate { get; private set; }



    public enum State
    {
        Idle,
        Move,
        Interaction
    }

    private State state = State.Idle;

    protected virtual State playerstate
    {
        get { return state; }
        set
        {
            state = value;

            Animator anim = GetComponent<Animator>();
            switch (state)
            {
               
                case State.Idle:
                    anim.CrossFade("Idle", 0.1f);
                    break;
                case State.Move:
                    anim.CrossFade("Move", 0.1f);
                    break;
                case State.Interaction:
                    anim.CrossFade("Interaction", 0.8f, -1, 0);
                    break;
            }
        }
    }
    protected void UpdateState()
    {

        switch (playerstate)
        {
            case State.Idle:
                UpdateIdle();
                break;
            case State.Move:
                UpdateMove();
                break;
            case State.Interaction:
                UpdateInteraction();
                break;
            
        }
    }
    protected virtual void UpdateIdle()
    {

    }
    protected virtual void UpdateMove()
    {

    }
    protected virtual void UpdateInteraction()
    {

    }

}
