using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TrailScript : MonoBehaviour
{

    TrailRenderer[] trailRenderers;
    // Use this for initialization
    void Start ()
    {
        trailRenderers = FindObjectsOfType<TrailRenderer>();
        DistanceFixer.distanceChange += disableTrail;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnDestroy()
    {
        DistanceFixer.distanceChange -= disableTrail;
    }

    void disableTrail()
    {
        for (int i = 0; i < trailRenderers.Length; ++i)
        {
            trailRenderers[i].enabled = false;
            trailRenderers[i].Clear();
        }
        
    }

    void enableTrail()
    {
        for (int i = 0; i < trailRenderers.Length; ++i)
        {
            trailRenderers[i].enabled = true;
        }
    }

    public void toggleTrail()
    {
        if (trailRenderers[0].enabled)
            disableTrail();
        else
            enableTrail();


    }
}
