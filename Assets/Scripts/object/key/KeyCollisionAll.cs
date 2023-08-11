using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollisionAll : MonoBehaviour
{
    bool locked = true; // true면 잠긴 상태. false면 문 열림

    // 1. 알림창 컴포넌트 선언
    NoticeUI _notice;

    private GameObject collidingKey; // 충돌이 발생한 열쇠의 정보 저장. 맞는 열쇠인지 판단할 때 사용
    AudioSource[] arrayAudio; // [0]: 문 열리는 소리, [1]: 잠긴 소리

    public string doorName; // 문 정보(이름)


    void Start()
    {
        // 2. 알림창 script를 갖고 있는 객체를 찾아서 컴포넌트 연결
        _notice = FindObjectOfType<NoticeUI>();
        arrayAudio = GameObject.Find("DoorLock1").GetComponents<AudioSource>();

        doorName = gameObject.name; // 문(도어락)의 정보 (1,2,3)
    }

    // 열쇠와 충돌하는 동안 알림창 띄우기
    public void OnCollisionEnter(Collision collision)
    {
        // 열쇠와 충돌   // tag가 Key면 UI 띄움
        if (collision.gameObject.tag == "Key")
        {
            Vector3 collisionPosition = collision.contacts[0].point;
            // 3. 알림창 불러오기
            _notice.SUB("Use Key?", collisionPosition);

            collidingKey = collision.gameObject;
        }
    }

    // UI에서 '열쇠 사용' 버튼을 눌렀을 때 호출할 함수
    // 열쇠 사용 버튼을 눌렀을 때 맞는 열쇠인지 체크
    public void Check()
    {
        Debug.Log("Check() 호출");

        if (collidingKey != null)
        {
            if (doorName == "DoorLock1")
            {
                // 1반 잠금장치 == 1반 열쇠인 경우 // tag가 아니라 object name과 비교해야 함
                if (collidingKey.name == "Key1")
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

            else if (doorName == "DoorLock2")
            {
                // 2반 잠금장치 == 2반 열쇠인 경우 // tag가 아니라 object name과 비교해야 함
                if (collidingKey.name == "Key2")
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

            else if (doorName == "DoorLock3")
            {
                // 3반 잠금장치 == 3반 열쇠인 경우 // tag가 아니라 object name과 비교해야 함
                if (collidingKey.name == "Key3")
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
            Debug.Log(doorName + collidingKey.name + locked);
        }
    }

    public bool IsLocked()
    {
        return locked;
    }
}
