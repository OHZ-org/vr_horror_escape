using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollisionAll : MonoBehaviour
{
    bool locked = true; // true면 잠긴 상태. false면 문 열림

    // 1. 알림창 컴포넌트 선언
    NoticeUI _notice;
    Door1 door1Sc;
    Door2 door2Sc;
    Door3 door3Sc;

    GameObject collidingKey; // 충돌이 발생한 열쇠의 정보 저장. 맞는 열쇠인지 판단할 때 사용
    AudioSource[] arrayAudio; // [0]: 문 열리는 소리, [1]: 잠긴 소리

    public string doorName; // 문 정보(이름)
    string keyNumber;

    public GameObject doorAnchor1;
    public GameObject doorAnchor2;
    public GameObject doorAnchor3;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    Animator door1Anim;
    Animator door2Anim;
    Animator door3Anim;
    Animator anchor1Anim;
    Animator anchor2Anim;
    Animator anchor3Anim;
    

    void Start()
    {
        // 2. 알림창 script를 갖고 있는 객체를 찾아서 컴포넌트 연결
        _notice = FindObjectOfType<NoticeUI>();
        arrayAudio = GameObject.Find("DoorLock1").GetComponents<AudioSource>();
        
        door1Sc = GetComponentInParent<Door1>();
        door2Sc = GetComponentInParent<Door2>();
        door3Sc = GetComponentInParent<Door3>();

        //doorName = gameObject.name; // 문(도어락)의 정보 (1,2,3)

        // string doorName을 private으로 바꾸고
        //if (gameObject.name == "DoorLock1")
        //{
        //    doorName = "DoorLock1";
        //}
        //else if (gameObject.name == "DoorLock2")
        //{
        //    doorName = "DoorLock2";
        //}
        //else if (gameObject.name == "DoorLock3")
        //{
        //    doorName = "DoorLock3";
        //} 이렇게 하면 될까...?

        Debug.Log(doorName);

        door1Anim = GetComponent<Animator>();
        door2Anim = GetComponent<Animator>();
        door3Anim = GetComponent<Animator>();
        anchor1Anim = GetComponent<Animator>();
        anchor2Anim = GetComponent<Animator>();
        anchor3Anim = GetComponent<Animator>();

    }

    // 열쇠와 충돌하는 동안 알림창 띄우기
    public void OnCollisionEnter(Collision collision)
    {
        // 열쇠와 충돌   // tag가 Key면 UI 띄움
        if (collision.gameObject.tag == "Key")
        {
            Vector3 collisionPosition = collision.contacts[0].point;
            
            collidingKey = collision.gameObject;
            keyNumber = collidingKey.name;

            // 3. 알림창 불러오기
            _notice.SUB("Use Key?", collisionPosition, keyNumber, this.name);
        }
    }

    // UI에서 '열쇠 사용' 버튼을 눌렀을 때 호출할 함수
    // 열쇠 사용 버튼을 눌렀을 때 맞는 열쇠인지 체크
    public void Check(string doorName, string keyName)
    {
        if (doorName == "DoorLock1")
        {
            if (keyName == "Key1")
            {
                door1Sc.SetBool(true);
                arrayAudio[0].Play();

            }
            else
            {
                arrayAudio[1].Play();

            }
        }

        else if (doorName == "DoorLock2")
        {
            if (keyName == "Key2")
            {
                door2Sc.SetBool(true);
                arrayAudio[0].Play();
            }
            else
            {
                arrayAudio[1].Play();
            }
        }

        else if (doorName == "DoorLock3")
        {
            if (keyName == "Key3")
            {
                door3Sc.SetBool(true);
                arrayAudio[0].Play();

            }
            else
            {
                arrayAudio[1].Play();

            }
        }

        /*Debug.Log("Check() 호출");

        
            if (UINum == 1)
            {
                Debug.Log("DoorLock1");
                // 1반 잠금장치 == 1반 열쇠인 경우 // tag가 아니라 object name과 비교해야 함
                if (keyNumber == "Key1")
                {
                    locked = false; // 문 잠금 해제

                    // 문 열리는 사운드 추가
                    arrayAudio[0].Play();
                }
                else
                {
                    locked = true; // 문 잠긴 상태 유지 (없어도 될듯)

                    // 문 잠긴 소리 (달그락) 추가
                    arrayAudio[1].Play();
                }
            }

            else if (UINum == 2)
            {
                Debug.Log("DoorLock2");

                // 2반 잠금장치 == 2반 열쇠인 경우 // tag가 아니라 object name과 비교해야 함
                if (keyNumber == "Key2")
                {
                    locked = false; // 문 잠금 해제

                    // 문 열리는 사운드 추가
                    arrayAudio[0].Play();
                }
                else
                {
                    locked = true; // 문 잠긴 상태 유지 (없어도 될듯)

                    // 문 잠긴 소리 (달그락) 추가
                    arrayAudio[1].Play();
                }
            }

            else if (UINum == 3)
            {
                Debug.Log("DoorLock3");

                // 3반 잠금장치 == 3반 열쇠인 경우 // tag가 아니라 object name과 비교해야 함
                if (keyNumber == "Key3")
                {
                    locked = false; // 문 잠금 해제

                    // 문 열리는 사운드 추가
                    arrayAudio[0].Play();
                }
                else
                {
                    locked = true; // 문 잠긴 상태 유지 (없어도 될듯)

                    // 문 잠긴 소리 (달그락) 추가
                    arrayAudio[1].Play();
                }
            }
            Debug.Log("Door:" + doorName + "Key:" + keyNumber + locked);*/
        
    }

    public bool IsLocked()
    {
        return locked;
    }
}
