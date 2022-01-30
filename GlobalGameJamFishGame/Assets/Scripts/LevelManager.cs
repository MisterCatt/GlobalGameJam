using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    GameObject blue;
    GameObject orange;
    private AmmountCheck ac1, ac2;
    private int blueScore, redScore;

    [SerializeField]
    GameObject obstacles;
    obstacleMovement om;
    [SerializeField] GameObject fish1;
    [SerializeField] GameObject fish2;

   
    void Start()
    {
        //CODE BELOW IS TEMPORARLY OUT COMMENTED WIP
        //blue = GameObject.Find("BlueCup");
        //orange = GameObject.Find("OrangeCup");
        //ac1 = blue.GetComponent<AmmountCheck>();
        //ac2 = orange.GetComponent<AmmountCheck>();
        //blueScore = ac1.AmmountCollected;
        //redScore = ac2.AmmountCollected;

        //takes the obstacleMovement script from obstacles
        om = obstacles.GetComponent<obstacleMovement>();

        //The 2 different scores we use to see how many points the different fishes have gathered
        blueScore = 0;
        redScore=0;

        Debug.Log("Red score: " + redScore + ", Blue score: " + blueScore);

    }

    private void Update()
    {

    }
    private void FixedUpdate()
    {
        //if any of the 2 scores go below 0, you DIE
        if(redScore < 0 || blueScore < 0)
        {
           // Dead();

        }

        //if the red score is 3 higher than the blue, play the fish eating animation
        if(redScore == blueScore+2)
        {
           // EatFish();
        }
        //if the blue score is 3 higher than the red, play the fish eating aniimation
        if(blueScore == redScore + 2)
        {
           // EatFish();
        }
        if(blueScore == 5 && redScore == 5)
        {
            Win();
        }
    }
    //adds a point to the red score
    public void addRedScore()
    {
        redScore++;
        Debug.Log("Red score: " + redScore);
    }
    //adds a point to the blue score
    public void addBlueScore()
    {
        blueScore++;
        Debug.Log("Blue score" + blueScore);
    }
    //removes 1 point from the red score
    public void removeRedScore()
    {
        redScore--;
        Debug.Log("Red score: " + redScore);
    }
    //removes 1 point from the blue score
    public void removeBlueScore()
    {
        blueScore--;
        Debug.Log("Blue score" + blueScore);
    }
    //returns red score
    public int getRedScore()
    {
        return redScore;
    }
    //returns the blue score
    public int getBlueScore()
    {
        return blueScore;
    }
    //function that is called when you die
    void Dead()
    {
        om.enabled = false;
        Debug.Log("DEADDEADDEAD");
        SceneManager.LoadScene("StartScreen");

    }
    //function that is called when 1 fish eats the other
    void EatFish()
    {
        om.enabled = false;
        Debug.Log("one fish ate the other!");
    }
    //function is called when you win
    void Win()
    {
        om.enabled = false;
        Debug.Log("Fish fusion activate!");
        // play white fish animation
        
        // dissable fish , reset speed apply a new sprite to anchor



    }
   
}
