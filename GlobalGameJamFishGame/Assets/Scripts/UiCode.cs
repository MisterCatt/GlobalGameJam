using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiCode : MonoBehaviour
{
    [SerializeField]
    private GameObject levelManager, text;
    LevelManager lm;
    // Start is called before the first frame update
    void Start()
    {
        lm = levelManager.GetComponent<LevelManager>();

        text.GetComponent<Text>().text = "Red score: " + lm.getRedScore() + " \nBlue score: " + lm.getBlueScore();

        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = "Red score: " + lm.getRedScore() + " \nBlue score: " + lm.getBlueScore();
    }
}
