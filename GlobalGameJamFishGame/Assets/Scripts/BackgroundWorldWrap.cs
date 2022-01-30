using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWorldWrap : MonoBehaviour
{
    [SerializeField]
    GameObject obstacles, screenTwo;
    obstacleMovement om;

    // Start is called before the first frame update
    void Start()
    {
        om = obstacles.GetComponent<obstacleMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //mooves the screens left
        transform.Translate(-Vector3.right * om.getSpeed() * Time.deltaTime);

        //Moves the screen left, activates this code
        if (transform.position.x + transform.GetComponent<SpriteRenderer>().bounds.size.x/2 < Camera.main.ScreenToWorldPoint(Vector3.zero).x)
        {
            transform.position = new Vector3(screenTwo.transform.position.x + screenTwo.GetComponent<SpriteRenderer>().bounds.size.x,transform.position.y,transform.position.z);
        }
    }
}
