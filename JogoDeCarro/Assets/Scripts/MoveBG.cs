using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveBG : MonoBehaviour
{
    private bool hasInstantiate= false;
    private float speed = -0.015f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= new Vector3(0, speed, 0);
        if(transform.position.y<= -13.13f)
        {
            Destroy(this.gameObject);
        }
        else if(transform.position.y <= -1f)
        {
            if (hasInstantiate==false)
            {
                hasInstantiate=true;
                GameObject obj = Instantiate(this.gameObject, new Vector3(transform.position.x,14.54f,transform.position.z), Quaternion.Euler(0,0,0));
            }
        }
    }
}
