using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{
   	
	public int Score;

  	// Start is called before the first frame update
    void Start()
    {
        Score = 3;
        Debug.Log(Score);
    }




    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by " + other.gameObject.name);
        Score += 1;
        Debug.Log(Score);
        
    }
}
