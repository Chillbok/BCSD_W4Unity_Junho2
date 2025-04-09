using UnityEngine;

public class OtherBall13 : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;   
    }

    //물리적 충돌이 시작될 때 호출되는 함수
    void OnCollisionEnter(Collision collision)
    //Collision: 충돌 정보 클래스
    {
        if(collision.gameObject.name == "Player")
        {
            //color: 기본 색상 클래스, color32: 255색상 클래스
            //검은색
            mat.color = new Color(0,0,0);
        }
    }

    //물리적 충돌이 일어나는 중 호출되는 함수
    void OnCollisionStay(Collision collision)
    {
    }

    //물리적 충돌이 끝났을 때 호출되는 함수
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            //흰색으로 바꾸기
            mat.color = new Color(1,1,1);
        }
    }
}
