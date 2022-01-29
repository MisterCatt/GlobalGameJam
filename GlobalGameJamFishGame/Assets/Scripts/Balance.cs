using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    public Sprite newSprite1, newSprite2, newSprite3;
   GameObject Blue ;
    GameObject Orange;
    private AmmountCheck AC1, AC2;
    SpriteRenderer render;
    Vector3 pos1, pos1low,pos1high;
    Vector3 pos2,pos2low,pos2high;



    void Start()
    {
        Blue = GameObject.Find("BlueCup");
       Orange = GameObject.Find("OrangeCup");
        AC1 = Blue.GetComponent<AmmountCheck>();
       AC2 = Orange.GetComponent<AmmountCheck>();
       render = gameObject.GetComponent<SpriteRenderer>();

        pos1 = AC1.transform.position;
        pos2 = AC2.transform.position;
        pos1low= pos1 + new Vector3(0, -10, 0);
        pos1high= pos1 + new Vector3(0, 10, 0);
        pos2low = pos2 + new Vector3(0, -10, 0);
        pos2high = pos2 + new Vector3(0, 10, 0);
    }

    
    void Update()
    {
        if (AC1.AmmountCollectedBlue==AC2.AmmountCollectedOrange)
        {
            render.sprite = newSprite1;
            AC1.transform.position = pos1;
            AC2.transform.position = pos2;

        }
        else if (AC1.AmmountCollectedBlue > AC2.AmmountCollectedOrange)
        {
           
                AC1.transform.position =pos1high;
                AC2.transform.position = pos2low;
                
            render.flipX = true;
            render.sprite = newSprite2;
        }
        else if (AC1.AmmountCollectedBlue < AC2.AmmountCollectedOrange)
        {
           
                AC2.transform.position = pos2high;
                AC1.transform.position = pos1low;
            render.flipX = false;
            render.sprite = newSprite3;
        }

    }
}
