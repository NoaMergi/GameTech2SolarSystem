/*
 Simulation properties:

 1s = 1h

 Scale: 1 unit = 1000km
 * 
 * distance formula for planets (sun radius/1000) - (planet radius/1000)+ (planet distance from sun /100,000)
 * revolusion formula
 * 
 * 
 * 696300 + (planet size/100000)
 * sun rad = 696.3
 * sun mercury distance -  139.26 +
 * 696,300
 * mercury - 115.82 + 696.3
 * pluto - 115.82 + 696.3
 
 
 */
using UnityEngine;


public class PlanetRotation : MonoBehaviour
{

    public GameObject ParentBody;

    //related to the object rotating on itself
    public bool Clockwise;
    public Vector3 RotationAxis;
    //amount of time planet takes to rotate on itself (hours) 
    public float RotationPeriod;



    //related to the object rotating around something else
    public float DistanceFromParentBody;
    public Vector3 RevolutionAxis;

    //amount of time planet takes to orbit (hours)
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
        transform.Rotate(Vector3.forward, TimeOfDay / RotationPeriod * 360.0f * RotationDirection , Space.Self);
    }


    void Year()
    {
        TimeOfYear += Time.deltaTime;
        if (ParentBody != null)
        {

            /*
            //transform.position = ParentBody.transform.position;
            
            transform.position = Vector3.Normalize(transform.position);
            
            //transform.RotateAround(ParentBody.transform.position, Vector3.up, TimeOfYear / RevolutionPeriod * 360.0f);
            transform.position = Quaternion.Euler(0, TimeOfYear / RevolutionPeriod * 360.0f, 0) * transform.position;

            //Debug.Log(transform.position);

            transform.Translate(DistanceFromParentBody * transform.position);

            transform.Translate(ParentBody.transform.position);

            //transform.position = new Vector3(transform.position.x + ParentBody.transform.position.x, transform.position.y + ParentBody.transform.position.y, transform.position.z + ParentBody.transform.position.z);

            */

            

            

                transform.position = ParentBody.transform.position;
                transform.Translate(DistanceFromParentBody * Vector3.right);
                transform.RotateAround(ParentBody.transform.position, Vector3.up, Time.deltaTime / RevolutionPeriod * 360.0f);
                 


        }
        else
            transform.position = new Vector3(DistanceFromParentBody, 0, 0);
        

        //Vector3.Normalize(transform.position);
        //Quaternion.Euler()
    }


    // Update is called once per frame
    void Update()
    {
        Year();
        //Debug.Log
        //Day();
    }

    void FixedUpdate()
    {

    }


}
