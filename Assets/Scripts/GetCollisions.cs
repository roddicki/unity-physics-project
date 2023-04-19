using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "wall3")
        {
            Debug.Log("its a hit");
        }
    }

}
