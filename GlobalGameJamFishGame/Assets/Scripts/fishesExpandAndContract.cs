using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishesExpandAndContract : MonoBehaviour
{
    public float maxRadius;
    public float minRadius;
    public float radiusChangeSpeed;
    public float upDownSpeed;

    public GameObject fish1;
    public GameObject fish2;

    public KeyCode contractingButton;
    public KeyCode expandingButton;
    public KeyCode up;
    public KeyCode down;

    public float rotationSpeed;
    public float temporaryRadius;
    Vector3 temporaryRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        upDownSpeed = 0.05f;
        temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y ,2));
        temporaryRotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(temporaryRadius >= minRadius)
        {
            if (Input.GetKey(contractingButton))
            {
                fish1.transform.position = Vector2.MoveTowards(fish1.transform.position, transform.position, radiusChangeSpeed);
                fish2.transform.position = Vector2.MoveTowards(fish2.transform.position, transform.position, radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y, 2));

            }
        }

        if(temporaryRadius <= maxRadius)
        {
            if (Input.GetKey(expandingButton))
            {
                fish1.transform.position = Vector2.MoveTowards(fish1.transform.position, transform.position, -radiusChangeSpeed);
                fish2.transform.position = Vector2.MoveTowards(fish2.transform.position, transform.position, -radiusChangeSpeed);
                temporaryRadius = Mathf.Sqrt(Mathf.Pow(fish1.transform.position.x - fish2.transform.position.x, 2) + Mathf.Pow(fish1.transform.position.y - fish2.transform.position.y, 2));


            }
        }

        if (Input.GetKey(up))
        {
            transform.position = new Vector3(0,transform.position.y+upDownSpeed,0);
        }else if (Input.GetKey(down))
        {
            transform.position = new Vector3(0, transform.position.y- upDownSpeed,0);
        }
        temporaryRotation.z -= rotationSpeed;
        transform.rotation = Quaternion.Euler(temporaryRotation);
        
    }
}
