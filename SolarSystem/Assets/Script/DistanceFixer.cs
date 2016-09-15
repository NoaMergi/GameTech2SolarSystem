using UnityEngine;
using System.Collections;

public class DistanceFixer : MonoBehaviour 
{

    public float scale = 0.03f;
	// Use this for initialization
	void Start () 
    {
        Transform[] transforms = FindObjectsOfType<Transform>();


        for (int i = 0; i < transforms.Length; i++ )
        {
            transforms[i].localPosition *= scale;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
