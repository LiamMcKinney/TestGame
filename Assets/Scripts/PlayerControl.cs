using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public float jumpHeight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetKeyDown(KeyCode.Space) ? jumpHeight : rb.velocity.y);
	}
}
