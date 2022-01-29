using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour
{
    public Sprite newSprite1, newSprite2, newSprite3;
   GameObject Blue ;
    GameObject Orange, obj;
    private AmmountCheck AC1, AC2;
   
    Vector3 pos1 ,pos1low,pos1high;
    Vector3 pos2 , pos2low,pos2high;
    public Image image;


    void Start()
    {
        Blue = GameObject.Find("BlueCup");
       Orange = GameObject.Find("OrangeCup");
        obj = GameObject.Find("Scale");
        AC1 = Blue.GetComponent<AmmountCheck>();
       AC2 = Orange.GetComponent<AmmountCheck>();
       
        image = obj.GetComponent<Image>();
       pos1 = Blue.transform.position;
       pos2 = Orange.transform.position;
       pos1low= pos1 + new Vector3(0, -37, 0);
        pos1high= pos1 + new Vector3(0, 35, 0);
        pos2low = pos2 + new Vector3(0, -37, 0);
        pos2high = pos2 + new Vector3(0, 35, 0);
    }

    
    void Update()
    {
        if (AC1.AmmountCollectedBlue==AC2.AmmountCollectedOrange)
        {
            
            image.sprite = newSprite1;
            
            Blue.transform.position = pos1;
            Orange.transform.position = pos2;

        }
        else if (AC1.AmmountCollectedBlue > AC2.AmmountCollectedOrange)
        {
           
                Blue.transform.position =pos1high;
                Orange.transform.position = pos2low;
                
            

            image.sprite = newSprite2;
           
            
        }
        else if (AC1.AmmountCollectedBlue < AC2.AmmountCollectedOrange)
        {
           
                Orange.transform.position = pos2high;
                Blue.transform.position = pos1low;
           
            
            image.sprite = newSprite3;
            
        }

    }
}
