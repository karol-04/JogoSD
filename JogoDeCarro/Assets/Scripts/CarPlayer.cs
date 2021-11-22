using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarPlayer : MonoBehaviour
{
    public static float score=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right")||Input.GetKey("d"))
        {
            transform.position+=new Vector3(0.02f,0,0);
        }
        else if(Input.GetKey("left")||Input.GetKey("a"))
        {
            transform.position+=new Vector3(-0.02f,0,0);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "inimigo")
        {
            Application.LoadLevel(Application.loadedLevel);
            CarPlayer.score=0;
        }
        
    }
}
