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
    public int coyoteTime;
    int framesSinceLeftGround = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetKeyDown(KeyCode.Space) && grounded ? jumpSpeed : rb.velocity.y);
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.GetContact(0).normal.Equals(Vector2.up))
        {
            grounded = true;
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
