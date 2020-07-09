using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("hit");
        PlayerControl player = collision.collider.gameObject.GetComponent<PlayerControl>();

        if (player != null)
        {
            print("ded");
            player.Die();
        }
    }
}
