using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public string nextLevel;
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
        PlayerControl player = collision.collider.gameObject.GetComponent<PlayerControl>();

        if (player != null)
        {
            print("won");
            SceneManager.LoadScene(nextLevel);
        }
    }
}
