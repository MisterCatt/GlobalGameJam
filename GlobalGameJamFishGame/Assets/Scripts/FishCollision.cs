using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    [SerializeField]
    GameObject levelManager;
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
        //REDFISH COLLISION
        if (collision.gameObject.tag == "Obstacle" && gameObject.tag == "RedFish")
        {
            Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            lm.removeRedScore();
        }
        if (collision.gameObject.tag == "RedStar" && gameObject.tag == "RedFish")
        {
            collision.gameObject.SetActive(false);
            lm.addRedScore();
        }
        if (collision.gameObject.tag == "BlueStar" && gameObject.tag == "RedFish")
        {
            Debug.Log("blue orb red fish collision");
        }
        //BLUEFISH COLLISION
        if (collision.gameObject.tag == "Objstacle" && gameObject.tag == "BlueFish")
        {
            lm.removeBlueScore();
        }
        if(collision.gameObject.tag == "BlueStar" && gameObject.tag == "BlueFish")
        {
            collision.gameObject.SetActive(false);
            lm.addBlueScore();
        }
        if(collision.gameObject.tag == "RedStar" &&  gameObject.tag == "BlueFish")
        {
            Debug.Log("red orb blue fish collision");
        }
    }
}
