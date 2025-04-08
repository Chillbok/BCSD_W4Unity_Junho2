using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 2.0f;
        /*
        Vector3 move = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed,
            0,
            Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed,
        );
        */
        Vector3 move = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed,
            0,
            Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed
        );
        transform.Translate(move);
    }
}
