using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarPlayer : MonoBehaviour
{
    private float move, moveSpeed, rotation, rotationSpeed;
    public AudioSource audioSource;
    void Start()
    {
        moveSpeed= 5f;
        rotationSpeed= 100f;
    }

    void Update()
    {
        move= Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        rotation= Input.GetAxis("Horizontal")*rotationSpeed*Time.deltaTime;
        if(Input.GetKey("b"))
        {
            audioSource.Play();
        }
    }
    
    private void LateUpdate()
    {
        transform.Translate(0f,move,0f);
        transform.Rotate(0f,0f, rotation);
    }
}
