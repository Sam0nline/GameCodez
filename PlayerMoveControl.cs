using UnityEngine;
using System.Collections;

public class PlayerMoveControl : MonoBehaviour {

    public float speed = 5f;
    public bool IsGrounded = false;
    public Rigidbody2D rb;
	
    // Update is called once per frame
    void Update()
    {
        var movementx = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
        transform.position += movementx * speed * Time.deltaTime;

        if (Input.GetKey (KeyCode.Space) && IsGrounded==true)
        {
            rb.velocity = new Vector3(0, 5, 0);
            IsGrounded = false;
            
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            IsGrounded = true;
        }
    }
}