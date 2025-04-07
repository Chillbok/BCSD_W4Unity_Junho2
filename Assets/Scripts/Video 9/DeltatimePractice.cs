using UnityEngine;

public class DeltatimePractice : MonoBehaviour
{
    float moveSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime
        );
        transform.Translate(vec);
    }
}
