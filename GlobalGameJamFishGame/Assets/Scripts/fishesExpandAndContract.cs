using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishesExpandAndContract : MonoBehaviour
{
    [SerializeField]
    float maxRadius, minRadius, radiusChangeSpeed, upDownSpeed,rotationSpeed,temporaryRadius,plussSpeed,minSpeed,maxSpeed;

    [SerializeField]
    KeyCode contractingButton, expandingButton, up, down;

    [SerializeField]
    GameObject fish1, fish2;

    Vector3 temporaryRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        
        temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y ,2));
        temporaryRotation = transform.rotation.eulerAngles;
        minSpeed = rotationSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(temporaryRadius >= minRadius)
        {
            if (Input.GetKey(contractingButton))
            {
                fish1.transform.position = Vector2.MoveTowards(fish1.transform.position, transform.position, radiusChangeSpeed);
                fish2.transform.position = Vector2.MoveTowards(fish2.transform.position, transform.position, radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y, 2));

                if (rotationSpeed > minSpeed)
                    rotationSpeed--;
            }
        }

        if(temporaryRadius <= maxRadius)
        {
            if (Input.GetKey(expandingButton))
            {
                fish1.transform.position = Vector2.MoveTowards(fish1.transform.position, transform.position, -radiusChangeSpeed);
                fish2.transform.position = Vector2.MoveTowards(fish2.transform.position, transform.position, -radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y, 2));

                if (rotationSpeed < maxSpeed)
                    rotationSpeed++;

            }
        }

        if (Input.GetKey(up))
        {
            if(transform.position.y <= 10)
            transform.position = new Vector3(0,transform.position.y+upDownSpeed,0);
        }else if (Input.GetKey(down))
        {
            if(transform.position.y >= -10)
            transform.position = new Vector3(0, transform.position.y- upDownSpeed,0);
        }
        temporaryRotation.z -= rotationSpeed;
        transform.rotation = Quaternion.Euler(temporaryRotation);
        
    }
}
