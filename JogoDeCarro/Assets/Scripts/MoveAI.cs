using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveAI : MonoBehaviour
{
    private float speed = -0.02f;
    private Text score;

    // Start is called before the first frame update
    void Start()
    {
        score= GameObject.Find("Canvas").transform.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= new Vector3(0, speed, 0);
        if(transform.position.y<= -13.13f)
        {
            Destroy(this.gameObject);
            CarPlayer.score++;
            score.text=CarPlayer.score.ToString();
        }
    }
}
