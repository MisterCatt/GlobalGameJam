using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{   
    public float speed;
    GameObject obstacle;
    Vector2 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = this.gameObject;
        tempPos = obstacle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos.x -= speed;
        obstacle.transform.position = tempPos;
    }
}
