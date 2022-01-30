using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoopManagement : MonoBehaviour
{
    public AudioSource track;
    public AudioSource trackEcho;

    // Start is called before the first frame update
    void Start()
    {
        track.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!track.isPlaying)
        {
            track.Play();
            trackEcho.Play();
        }
    }
}
