using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{

    public Vector3 offset;
    Quaternion orientation;

	// Use this for initialization
	void Start () 
    {
        orientation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () 
    {
       transform.localRotation = orientation;
        //transform.Rotate(offset,Space.World);
	}
}
