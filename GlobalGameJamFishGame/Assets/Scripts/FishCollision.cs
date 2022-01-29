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
        //Is called when an obstacle collides with the red fish
        if (collision.gameObject.tag == "Obstacle" && gameObject.tag == "RedFish")
        {
            Debug.Log(collision.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            lm.removeRedScore();
            DownSize();
            collision.gameObject.SetActive(false);
            
        }
        //Is called when the red fish collides with the red star
        if (collision.gameObject.tag == "RedStar" && gameObject.tag == "RedFish")
        {
            lm.addRedScore();
            UpSize();
            //PLAY A FANCY ROCK SMASH ANIMATION AND MAKE A FANCY ROCK SMASH SOUND
            collision.gameObject.SetActive(false);
        }
        //Is called when the blue star collides with the red fish
        if (collision.gameObject.tag == "BlueStar" && gameObject.tag == "RedFish")
        {
            Debug.Log("blue orb red fish collision");
        }
        //BLUEFISH COLLISION
        //is called when an obstacle collides with the blue fish
        if (collision.gameObject.tag == "Obstacle" && gameObject.tag == "BlueFish")
        {
            lm.removeBlueScore();
            DownSize();
            //PLAY A FANCY ROCK SMASH ANIMATION AND MAKE A FANCY ROCK SMASH SOUND
            collision.gameObject.SetActive(false);
        }
        //is called when the blue star collides with the blue fish
        if(collision.gameObject.tag == "BlueStar" && gameObject.tag == "BlueFish")
        {
            collision.gameObject.SetActive(false);
            lm.addBlueScore();
            UpSize();
        }
        //is called when the red star collides with the blue fish
        if(collision.gameObject.tag == "RedStar" &&  gameObject.tag == "BlueFish")
        {
            Debug.Log("red orb blue fish collision");
        }
    }
    //Code that makes the fish larger (is called in the the blue on blue or red on red collision check)
    private void UpSize()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x*sizeChange, gameObject.transform.localScale.y*sizeChange,0);
    }
    //Code that makes the fish smaller (is called in the the blue on obstacle or red on obstacle collision check)
    private void DownSize()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / sizeChange, gameObject.transform.localScale.y / sizeChange, 0);
    }
}
