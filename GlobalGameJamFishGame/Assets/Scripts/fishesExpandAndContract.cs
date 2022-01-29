using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishesExpandAndContract : MonoBehaviour
{
    //IF YOU NEED ANY OF THESE VARIABLES, MAKE A GETTER OR A SETTER AND DONT JUST RANDOMLY MAKE A PUBLIC VARIABLE. You will make jerry sad :(

    [SerializeField]
    float maxRadius, minRadius, radiusChangeSpeed, upDownSpeed, leftRightSpeed, rotationSpeed, temporaryRadius, plussSpeed, minSpeed, maxSpeed, minYPosition, maxYPosition, minXPosition, maxXPosition;

    [SerializeField]
    KeyCode contractingButton, expandingButton, up, down, left, right;

    [SerializeField]
    GameObject fish1, fish2;

    Vector3 temporaryRotation;

    public AudioSource expandSFX;
    public AudioSource shrinkSFX;

    bool soundIsPlaying = false;
    float currentTime;
    int counter;
    
    // Start is called before the first frame update
    void Start()
    {
        
        temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y ,2));
        temporaryRotation = transform.rotation.eulerAngles;
        minSpeed = rotationSpeed;
        counter = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter > 30)
        {
            soundIsPlaying = false;
        }

        if(temporaryRadius > minRadius)
        {
            if (Input.GetKey(contractingButton))
            {
                fish1.transform.position = Vector2.MoveTowards(fish1.transform.position, transform.position, radiusChangeSpeed);
                fish2.transform.position = Vector2.MoveTowards(fish2.transform.position, transform.position, radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y, 2));

                if (!soundIsPlaying)
                {
                    counter = 0;
                    soundIsPlaying = true;
                    shrinkSFX.Play();
                }

                //lessens the speed when you become smaller
                if (rotationSpeed > minSpeed)
                    rotationSpeed-=plussSpeed;
            }
        }

        if(temporaryRadius < maxRadius)
        {
            if (Input.GetKey(expandingButton))
            {
                fish1.transform.position = Vector2.MoveTowards(fish1.transform.position, transform.position, -radiusChangeSpeed);
                fish2.transform.position = Vector2.MoveTowards(fish2.transform.position, transform.position, -radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y, 2));

                if (!soundIsPlaying)
                {
                    counter = 0;
                    soundIsPlaying = true;
                    expandSFX.Play();
                }

                //upps the speed when you become larger
                if (rotationSpeed < maxSpeed)
                    rotationSpeed+=plussSpeed;

            }
        }

        //Moves the anchors y position up and down
        if (Input.GetKey(up))
        {
            if(transform.position.y < maxYPosition)
            transform.position = new Vector3(transform.position.x,transform.position.y+upDownSpeed,0);
        }else if (Input.GetKey(down))
        {
            if(transform.position.y > minYPosition)
            transform.position = new Vector3(transform.position.x, transform.position.y- upDownSpeed,0);
        }

        temporaryRotation.z -= rotationSpeed;
        transform.rotation = Quaternion.Euler(temporaryRotation);

<<<<<<< HEAD
        //if (Input.GetKey(left))
        //{
        //    if(transform.position.x > minXPosition)
        //    {
        //        transform.position = new Vector3(transform.position.x - leftRightSpeed, transform.position.y, 0);
        //    }
        //}
        //else if (Input.GetKey(right))
        //{
        //    if(transform.position.x < maxXPosition)
        //    {
        //        transform.position = new Vector3(transform.position.x + leftRightSpeed, transform.position.y , 0);
        //    }
        //}
        
=======
        if (Input.GetKey(left))
        {
            if(transform.position.x > minXPosition)
            {
                transform.position = new Vector3(transform.position.x - leftRightSpeed, transform.position.y, 0);
            }
        }
        else if (Input.GetKey(right))
        {
            if(transform.position.x < maxXPosition)
            {
                transform.position = new Vector3(transform.position.x + leftRightSpeed, transform.position.y , 0);
            }
        }
        counter++;
>>>>>>> 1259f6caa17e23a4cc820ef68dc820aca64a31f9
    }
}
