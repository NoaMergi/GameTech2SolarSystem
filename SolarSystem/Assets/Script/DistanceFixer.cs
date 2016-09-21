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
            if (transforms[i].GetComponent<Camera>() == null)
            {
                transforms[i].localPosition = scale * transforms[i].localPosition;
                //Debug.Log(transforms[i].name);
            }

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
