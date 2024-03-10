using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemys : MonoBehaviour
{
    public GameObject Enemy;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1.0f)
        {
            timer = 0;
            Instantiate(Enemy,new Vector3(Random.Range(-5.51f,9.92f),transform.position.y,transform.position.z),Quaternion.Euler(0,0,0f));
        }
    }
}
