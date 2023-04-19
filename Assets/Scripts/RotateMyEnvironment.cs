using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMyEnvironment : MonoBehaviour
{

	Vector3 XRotationToAdd;
	Vector3 YRotationToAdd;
	Vector3 ZRotationToAdd;

    // Start is called before the first frame update
    void Start()
    {
       XRotationToAdd = new Vector3(5, 0, 0);
       YRotationToAdd = new Vector3(0, 5, 0);
       ZRotationToAdd = new Vector3(0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(RotationToAdd * Time.deltaTime);

        if (Input.GetKey("up"))
        {
            print("up arrow key is held down");
            transform.Rotate(XRotationToAdd * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            print("down arrow key is held down");
            transform.Rotate(YRotationToAdd * Time.deltaTime);
        }


    }
}
