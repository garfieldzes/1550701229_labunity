using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public Vector2 velocity;
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;



    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
            rb.velocity = new Vector3(0, 7, 0);
  
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector2(-1, 0) * moveSpeed * Time.deltaTime);
    }

}
 
   


