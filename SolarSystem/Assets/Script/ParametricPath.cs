using UnityEngine;
using System.Collections;

public class ParametricPath : MonoBehaviour {

    public GameObject parent = null;

    public float Radius;

    public float Period;

    private float PeriodStep;

    public Vector3 Normal;

    public float A;

    public float B;

    public bool IsClockwise;

   private int Direction;

	// Use this for initialization
	void Start () 
    {
        if (IsClockwise)
        {
            Direction = 1;
        }
        else
        {
            Direction = -1;
        }
	}



    Vector3 Circle(Vector3 origin, Vector3 normal, float angle, float radius)
    {
        normal.Normalize();

        Vector3 point = origin;

        point.x += radius * Mathf.Cos(angle * Mathf.Deg2Rad);

        point.z += radius * Mathf.Sin(angle * Mathf.Deg2Rad);

        return Quaternion.FromToRotation(Vector3.up, normal)*point;
    }

    
    Vector3 Circle(Transform objectTransform, float angle, float radius)
    {
        Vector3 point = objectTransform.position;

        point.x += radius * Mathf.Cos(angle * Mathf.Deg2Rad);

        point.z += radius * Mathf.Sin(angle * Mathf.Deg2Rad);

        return objectTransform.rotation * point;
    }


    Vector3 Ellipse(Vector3 origin, Vector3 normal, float angle, float a, float b)
    {
        normal.Normalize();

        Vector3 point = origin;

        point.x += a * Mathf.Cos(angle * Mathf.Deg2Rad) * Direction;

        point.z += b * Mathf.Sin(angle * Mathf.Deg2Rad) * Direction;

        return Quaternion.FromToRotation(Vector3.up, normal) * point;

    }



    // Update is called once per frame
    void Update () {

        PeriodStep += Time.deltaTime;

        float angle = PeriodStep / Period * 360.0f;

        //transform.localPosition = Circle(parent.transform.position, Normal, angle, Radius);
        transform.localPosition = Ellipse(parent.transform.position, Normal, angle, A, B);
	}
}
