using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GenerateEnemys : MonoBehaviour
{
    public GameObject inimigo;
    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if( timer>=1.5f)
        {
            timer=0;
            Instantiate(inimigo, new Vector3(Random.Range(-9.59f,-3.8f),transform.position.y, transform.position.z), Quaternion.Euler(0,0,-180f));
        }
    }
}
