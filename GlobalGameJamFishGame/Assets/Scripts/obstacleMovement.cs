using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    
    GameObject[] obstacles;
    [SerializeField]
    float speed, upperLowerThreshHold;
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
            if(o.transform.position.x < Camera.main.ScreenToWorldPoint(Vector3.zero).x)
            {
                o.transform.position = new Vector3(100,o.transform.position.y,o.transform.position.z);
            }
            //World wrap
            //lower bound
            if(o.transform.position.y < Camera.main.ScreenToWorldPoint(Vector3.zero).y-(o.transform.localScale.x*upperLowerThreshHold))
            {
                o.transform.position = new Vector3(o.transform.position.x, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).y + o.transform.localScale.x,o.transform.position.z);
            }
            //upper bound
            if(o.transform.position.y > Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).y + (o.transform.localScale.x* upperLowerThreshHold))
            {
                o.transform.position = new Vector3(o.transform.position.x, Camera.main.ScreenToWorldPoint(Vector3.zero).y - o.transform.localScale.x,o.transform.position.z);
            }
        }
    }

    public float getSpeed()
    {
        return speed;
    }
}
