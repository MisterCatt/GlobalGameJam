using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    GameObject[] obstacles;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        obstacles = new GameObject[transform.childCount];

     for(int i = 0; i < transform.childCount; i++)
        {
            obstacles[i] = transform.GetChild(i).gameObject;
        }   
    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(obstacles.Length);
        foreach (GameObject o in obstacles)
        {
            //Debug.Log(o.name);
            o.transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
    }
}
