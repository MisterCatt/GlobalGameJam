using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    [SerializeField]
    GameObject levelManager;
    LevelManager lm;
    [SerializeField]
    float sizeChange;

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
            DownSize();
            
        }
        if (collision.gameObject.tag == "RedStar" && gameObject.tag == "RedFish")
        {
            collision.gameObject.SetActive(false);
            lm.addRedScore();
            UpSize();

        }
        if (collision.gameObject.tag == "BlueStar" && gameObject.tag == "RedFish")
        {
            Debug.Log("blue orb red fish collision");
        }
        //BLUEFISH COLLISION
        if (collision.gameObject.tag == "Obstacle" && gameObject.tag == "BlueFish")
        {
            lm.removeBlueScore();
            DownSize();
        }
        if(collision.gameObject.tag == "BlueStar" && gameObject.tag == "BlueFish")
        {
            collision.gameObject.SetActive(false);
            lm.addBlueScore();
            UpSize();
        }
        if(collision.gameObject.tag == "RedStar" &&  gameObject.tag == "BlueFish")
        {
            Debug.Log("red orb blue fish collision");
        }
    }

    private void UpSize()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x*sizeChange, gameObject.transform.localScale.y*sizeChange,0);
    }
    private void DownSize()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / sizeChange, gameObject.transform.localScale.y / sizeChange, 0);
    }
}
