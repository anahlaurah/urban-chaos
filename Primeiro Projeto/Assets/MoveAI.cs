using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAI : MonoBehaviour
{
    private Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,-0.010f,0);
        if (transform.position.y <= -6.39)
        {
            MovePlayer.Score++;
            Score.text = MovePlayer.Score.ToString();
            Destroy(this.gameObject);
        }
    }
}
