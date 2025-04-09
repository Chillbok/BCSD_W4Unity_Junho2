using UnityEngine;

public class PowerMove : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //실습 영상에서는 rigid.velocity를 사용하라고 했지만, Unity에서 인식하지 못하는 문제가 발생했다. 따라서 linearVelocity를 사용했다.

        //#1. 속력 바꾸기
        //rigid.linearVelocity = Vector3.forward;
    }

    void FixedUpdate()
    {
        //rigid.linearVelocity = new Vector3(2,4,-1);
        //#2. 힘을 가하기
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(
                Vector3.up * 50,    //벡터 방향
                ForceMode.Impulse   //힘을 주는 방식
                );
            Debug.Log(rigid.linearVelocity);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * 2,
            0,
            Input.GetAxisRaw("Vertical") * 2
            );

        rigid.AddForce(vec, ForceMode.Impulse);

        //#3. 회전력
        //rigid.AddTorque(Vector3.up);
    }

    void Update()
    {
    }
}
