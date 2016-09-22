using UnityEngine;
using System.Collections;

public class PlanetDataScript : MonoBehaviour 
{

    public float PlanetRadius;
    public float SizeScale;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public float getRad()
    {
        return PlanetRadius * SizeScale;
    }
}
