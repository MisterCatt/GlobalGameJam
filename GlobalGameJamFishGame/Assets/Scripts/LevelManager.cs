using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    
    GameObject blue;
    GameObject orange;
    private AmmountCheck ac1, ac2;
    private int blueScore, redScore;

    [SerializeField]
    GameObject obstacles;
    obstacleMovement om;
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
            Dead();
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
    }
    //function is called when you win
    void Win()
    {
        om.enabled = false;
        Debug.Log("Fish fusion activate!");
    }
   
}
