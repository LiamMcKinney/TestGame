using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public float jumpSpeed;
    bool grounded = true;
    public Camera cam;
    public Vector3 offset;
    public int coyoteTime;
    int framesSinceLeftGround = 0;
    bool canJump;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cam.transform.position = transform.position + offset;
        framesSinceLeftGround++;
        if (grounded)
        {
            framesSinceLeftGround = 0;
        }

        if(framesSinceLeftGround > coyoteTime)
        {
            canJump = false;
        }

        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, jumpSpeed);
            canJump = false;
        }
        else
        {
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        }
        
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.GetContact(0).normal.Equals(Vector2.up))
        {
            grounded = true;
            canJump = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
