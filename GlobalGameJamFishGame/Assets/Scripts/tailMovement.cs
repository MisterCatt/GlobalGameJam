using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tailMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes the fish tail folow the parent object (atatch this script to the fish tail)
        transform.position = Vector3.MoveTowards(transform.position,transform.parent.position, 0.0f);
    }
}
