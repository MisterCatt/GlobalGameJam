using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAnimationControl : MonoBehaviour
{
    public Animator anim;

    public float offsetTime = 0.1f;
    private float timer = 0f;

    bool temp;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "RedFish")
        {
            anim.Play("asteroidanim1");
        }
    }
}

