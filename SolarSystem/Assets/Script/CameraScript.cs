using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.LookAt(transform.parent.transform.position);
        //transform.RotateAround(planet.transform.position,1);
	}
}
