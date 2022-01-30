using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trasnsitiontoplayscene : MonoBehaviour
{
    public AudioSource startButtonMusic;
    public AudioSource menuMusic;
    float timeLeft = 0;
    bool pressed = false;

    void Update()
    {
        if (pressed)
        {
            timeLeft -= Time.deltaTime;
            menuMusic.volume -= Time.deltaTime * 0.03f;
        }
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Daniels test level 1.1");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!pressed)
            {
                timeLeft = 4.18f;
                DontDestroyOnLoad(startButtonMusic);
                startButtonMusic.Play();
                pressed = true;
            }
        }
    }
}