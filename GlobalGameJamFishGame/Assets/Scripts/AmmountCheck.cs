using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmountCheck : MonoBehaviour
{
   public Sprite newSprite1, newSprite2, newSprite3,newSprite4,newSprite5;
    public int AmmountCollected = 0;
    GameObject obj;
    Animator animator;
    SpriteRenderer renderer;

    
    void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (AmmountCollected > 0 && AmmountCollected <= 2)
        {
            renderer.sprite = newSprite1;
           
        }
        else if (AmmountCollected > 2 && AmmountCollected <= 4)
        {
            renderer.sprite = newSprite2;
        }
        else if (AmmountCollected > 4 && AmmountCollected <= 6)
        {
            renderer.sprite = newSprite3;
        }
        else if (AmmountCollected > 6 && AmmountCollected <= 8)
        {
            renderer.sprite = newSprite4;
        }
        else if (AmmountCollected > 8 && AmmountCollected <= 10)
        {
            renderer.sprite = newSprite5;
        }
    }
    
 
}
