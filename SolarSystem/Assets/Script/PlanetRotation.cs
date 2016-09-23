/*
 Simulation properties:

 1s = 1h

 Scale: 1 unit = 1000km
 
 
 */
 using UnityEngine;


public class PlanetRotation : MonoBehaviour
{

    public GameObject ParentBody;

    //related to the object rotating on itself
    public bool Clockwise;
    public Vector3 RotationAxis;
    //amount of time planet takes to rotate on itself
    public float RotationPeriod;

    public static Vector3 berrayCenter;
    public bool isPlanet = false;

    //related to the object rotating around something else
    public float DistanceFromParentBody;
    public Vector3 RevolutionAxis;
    public float RevolutionPeriod;
    private float TimeOfYear;

    //
    private float TimeOfDay;
    private float RotationDirection;

    
    void Start()
    {
        TimeOfDay = 0;
        if (Clockwise)
            RotationDirection = 1.0f;
        else
            RotationDirection = -1.0f;
    }


    void Day()
    {
        transform.rotation = Quaternion.identity;
        transform.Rotate(Vector3.right, -90.0f, Space.Self);
        ///here we rotate the planet by a fixed amount each frame
        TimeOfDay += Time.deltaTime;
        transform.Rotate(Vector3.forward, TimeOfDay / RotationPeriod * 360.0f * RotationDirection, Space.Self);
    }


    void Year()
    {
        TimeOfYear += Time.deltaTime;
        if (ParentBody != null)
        {
            transform.position = ParentBody.transform.position;
            transform.Translate(DistanceFromParentBody * Vector3.right);
            if (isPlanet)
                transform.RotateAround(ParentBody.transform.position + berrayCenter, Vector3.up, TimeOfYear / RevolutionPeriod * 360.0f);
            else
                transform.RotateAround(ParentBody.transform.position, Vector3.up, TimeOfYear / RevolutionPeriod * 360.0f);
        }
        else
            transform.position = new Vector3(DistanceFromParentBody, 0, 0);

        

    }


	// Update is called once per frame
	void Update () {
        Year();
        Day();
	}

    void FixedUpdate()
    {

    }


}
