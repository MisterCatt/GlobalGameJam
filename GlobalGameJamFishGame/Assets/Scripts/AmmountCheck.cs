using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmountCheck : MonoBehaviour
{
    public Sprite newSprite1, newSprite2, newSprite3, newSprite4, newSprite5;
    public Sprite newSprite6, newSprite7, newSprite8, newSprite9, newSprite10;
    public int AmmountCollectedBlue, AmmountCollectedOrange;
    GameObject obj1, obj2, lm;
    LevelManager levelManager;
    Sprite sp;
    Texture2D txt;
    public Image image1, image2;

    void Start()
    {


        obj1 = GameObject.FindWithTag("BlueCup");
        obj2 = GameObject.FindWithTag("OrangeCup");
        lm = GameObject.FindGameObjectWithTag("LevelManager");
        levelManager = lm.GetComponent<LevelManager>();

        image1 = obj1.GetComponent<Image>();
        image2 = obj2.GetComponent<Image>();

    }
    void Update()
    {
       AmmountCollectedBlue = levelManager.getBlueScore();
       AmmountCollectedOrange = levelManager.getRedScore();


        if (AmmountCollectedBlue > 0 && AmmountCollectedBlue <= 2)
        {
            image1.sprite = newSprite1;
        }
        else if (AmmountCollectedBlue > 2 && AmmountCollectedBlue <= 4)
        {
            image1.sprite = newSprite2;
        }
        else if (AmmountCollectedBlue > 4 && AmmountCollectedBlue <= 6)
        {
            image1.sprite = newSprite3;
        }
        else if (AmmountCollectedBlue > 6 && AmmountCollectedBlue <= 8)
        {
            image1.sprite = newSprite4;
        }
        else if (AmmountCollectedBlue > 8 && AmmountCollectedBlue <= 10)
        {
            image1.sprite = newSprite5;
        }



        if (AmmountCollectedOrange > 0 && AmmountCollectedOrange <= 2)
        {
            image2.sprite = newSprite6;
        }
        else if (AmmountCollectedOrange > 2 && AmmountCollectedOrange <= 4)
        {
            image2.sprite = newSprite7;
        }
        else if (AmmountCollectedOrange > 4 && AmmountCollectedOrange <= 6)
        {
            image2.sprite = newSprite8;
        }
        else if (AmmountCollectedOrange > 6 && AmmountCollectedOrange <= 8)
        {
            image2.sprite = newSprite9;
        }
        else if (AmmountCollectedOrange > 8 && AmmountCollectedOrange <= 10)
        {
            image2.sprite = newSprite10;
        }



    }
}
