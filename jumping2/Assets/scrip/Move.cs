using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;

    void Update()
    {
        //Next two if statements are for moving left and right
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector2(-1, 0) * moveSpeed * Time.deltaTime);
    }
   
}