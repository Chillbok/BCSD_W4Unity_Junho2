using UnityEngine;

public class MyBall13 : MonoBehaviour
{
    Rigidbody rigid;
    float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        moveSpeed = 10.0f;
    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(
                Vector3.up * 10,    //벡터 방향
                ForceMode.Impulse   //힘을 주는 방식
            );
        }

        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    void OnTriggerStay(Collider other)
    //Collider: 물리적 충돌이 아닌 겹침
    {
        if (other.name == "Area")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}

/*
//실제 물리적인 충돌로 발생하는 이벤트
void OnCollisionEnter(Collision other) { }
void OnCollisionStay(Collision other) { }
void OnCollisionExit(Collision other) { }

//콜라이더 충돌로 발생하는 이벤트
void OnTriggerEnter(Collider other) { }
void OnTriggerStay(Collider other) { }
void OnTriggerExit(Collider other) { }
*/