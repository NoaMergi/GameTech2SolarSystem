using UnityEngine;
using System.Collections;

public class ParametricPath : MonoBehaviour
{

    public GameObject parent;

    

    public float Radius;

    public float Period;

    public Vector3 Orientation;

    public Vector3 berrayCenter;
    public Vector3 ScaledberrayCenter;
    public bool isPlanet = false;


    [SerializeField]
    private float A;

    [SerializeField]
    private float B;

    public bool IsClockwise;

    private float ParentRad;

    private float PeriodStep;

    private int Direction;

    [HideInInspector]
    public float scaledA;

    [HideInInspector]
    public float scaledB;

	// Use this for initialization
	void Start () 
    {
        scaledA = A;
        scaledB = B;

        ParentRad = parent.GetComponent<PlanetDataScript>().getRad();
        if (IsClockwise)
        {
            Direction = 1;
        }
        else
        {
            Direction = -1;
        }

        berrayCenter = new Vector3(14.9999551f, 0, 0);
        ScaledberrayCenter = new Vector3(14.9999551f, 0, 0);
}

    public float getA()
    {
        return A;
    }

    public float getB()
    {
        return B;
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
    void Update () 
    {

        PeriodStep += Time.deltaTime;

        float angle = PeriodStep / Period * 360.0f;
        //transform.localPosition = Circle(parent.transform.position, Normal, angle, Radius);
        if (isPlanet)
            transform.localPosition = Ellipse(parent.transform.position + ScaledberrayCenter, Orientation, angle, scaledA + ParentRad, scaledB + ParentRad);
        else
            transform.localPosition = Ellipse(parent.transform.position, Orientation, angle, scaledA + ParentRad, scaledB + ParentRad);
	}
}
