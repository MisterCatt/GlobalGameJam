using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAnimationControl : MonoBehaviour
{
    public Animator anim;

    private float timer = 0f;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "RedFish" || collision.tag == "BlueFish")
        {
            if(transform.GetComponent<SpriteRenderer>().sprite.name == "Asteroid")
            anim.Play("asteroidanim1");
            else if (transform.GetComponent<SpriteRenderer>().sprite.name == "Asteroid_2")
            anim.Play("asteroidanim2");
            else
            anim.Play("asteroidanim3");
        }
    }
}

