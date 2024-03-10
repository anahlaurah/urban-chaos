using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public static float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }else if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            MovePlayer.Score = 0;
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}