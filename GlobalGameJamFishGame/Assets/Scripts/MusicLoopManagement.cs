using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoopManagement : MonoBehaviour
{
    public AudioSource track;
    public AudioSource trackEcho;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (track.clip.length < currentTime)
        {
            trackEcho.Play();
            currentTime = 0;
        }
    }
}
