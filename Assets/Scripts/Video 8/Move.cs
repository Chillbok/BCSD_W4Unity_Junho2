using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(5,1.3f,0);
    // Update is called once per frame
    int point = 4;
    void Update()
    {
        Vector3 velo = Vector3.zero;
        if(point == 1)
        {
            //1. MoveTowards(단순 등속 이동)
            Debug.Log("MoveTowards 실행");
            transform.position = Vector3.MoveTowards(
                transform.position, //현재 위치 벡터
                target,             //목표 위치 벡터
                1f                  //한 프레임 동안 이동할 수 있는 최대 거리
                );
            Debug.Log("MoveTowards 실행 완료");
        }
        else if(point == 2)
        {
            //2. SmoothDamp(미끄러지듯이 감속 이동)
            Debug.Log("SmoothDamp 실행");
            transform.position = Vector3.SmoothDamp(
                transform.position, //현재 벡터 값
                target,             //목표 벡터 값(도달하고자 하는 최종 위치)
                ref velo,           //현재 속도 젝터를 저장하는 변수. Vector3.zero로 초기화하는 것이 일반적.
                0.1f                //목표 값에 도달하는 데 대략적으로 걸리는 시간(초). 값이 작을수록 더 빠르게 목표에 도달.
                );
            Debug.Log("SmoothDamp 실행 완료");
        }
        else if(point == 3)
        {
            //3. Lerp(선형 보간)
            Debug.Log("Lerp 실행");
            transform.position = Vector3.Lerp(
                    transform.position, //시작 벡터
                    target,             //목표 벡터
                    0.1f                //보간 비율. 0.0f ~ 1.0f 사이의 float 값을 가짐.
                );
            Debug.Log("Lerp 실행 완료");
        }
        else if(point == 4)
        {
            //4. Slerp(구형 선형 보간)
            Debug.Log("Slerp 실행");
            transform.position = Vector3.Slerp(
                transform.position, //시작 벡터
                target,             //목표 벡터
                0.005f              //보간 비율. 0.0f ~ 1.0f 사이의 float 값을 가짐.
            );
            Debug.Log("Slerp 실행 완료");
        }
    }
}