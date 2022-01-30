using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    [SerializeField]
    GameObject levelManager;
    LevelManager lm;

    // Start is called before the first frame update
    //takes the ui text and prints it out in the ui
    void Start()
    {
        lm = levelManager.GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
