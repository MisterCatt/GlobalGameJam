using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusicOnStart : MonoBehaviour
{
    public AudioSource startButtonMusic;
    public AudioSource startMenuMusic;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (startButtonMusic.isPlaying)
        {
            startButtonMusic.volume--;
        }
    }
}
