using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    public GameObject levelManager;
    LevelManager lm;

    // Start is called before the first frame update
    void Start()
    {
        lm = levelManager.GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        }
        if(collision.gameObject.tag == "RedStar" && gameObject.tag == "RedFish")
        {
            collision.gameObject.SetActive(false);
            lm.addRedScore();
        }
        if(collision.gameObject.tag == "BlueStar" && gameObject.tag == "BlueFish")
        {
            collision.gameObject.SetActive(false);
            lm.addBlueScore();
        }
        if(collision.gameObject.tag == "BlueStar" && gameObject.tag == "RedFish")
        {
            Debug.Log("blue orb red fish collision");
        }
        if(collision.gameObject.tag == "RedStar" &&  gameObject.tag == "BlueFish")
        {
            Debug.Log("red orb blue fish collision");
        }
        else
        {
            Debug.Log("collided with: " + collision.gameObject.name);
        }
    }
}
