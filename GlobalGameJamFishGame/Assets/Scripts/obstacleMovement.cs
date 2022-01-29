using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    
    GameObject[] obstacles;
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        obstacles = new GameObject[transform.childCount];
        //takes all the objects under the obstacle tag in the hierarchy and adds them to the array
     for(int i = 0; i < transform.childCount; i++)
        {
            obstacles[i] = transform.GetChild(i).gameObject;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        //takes everything from the array and moves it to the left
        foreach (GameObject o in obstacles)
        {
            o.transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
    }
}
