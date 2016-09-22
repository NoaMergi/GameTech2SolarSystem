using UnityEngine;
using System.Collections.Generic;

public class RotationScript : MonoBehaviour
{

    //6.963


    public bool isClockwise = true;
    public float rotationPeriodInHours;

    Transform[] Children;

    public Vector3 offsetAxis;
    public Vector3 rotationAxis = Vector3.up;

    private const float timescale = 1f;

    //Rotation progress between 0 and 1
    private float currentTime = 0f;

    void Start()
    {
        Debug.Log(transform.childCount);
        Children = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        //Debug.Log((Time.deltaTime * timescale / rotationPeriodInHours).ToString("F9"));
        currentTime += Time.deltaTime * timescale / rotationPeriodInHours;
        currentTime %= 1.0f;

        float currentRotationAngle = currentTime * 360f;

        

        if( !isClockwise )
        {
            currentRotationAngle *= -1f;
        }

        transform.DetachChildren();

        transform.rotation = Quaternion.AngleAxis( currentRotationAngle, rotationAxis);
        transform.Rotate(offsetAxis);
        /*
        if (camera != null)
        {
            camera.transform.parent = transform;
        }*/

        foreach (Transform child in Children)
        {
            child.parent = transform;
            Debug.Log("parent");
            //child is your child transform
        }
        
        //transform.rotation = Quaternion.AngleAxis(offsetValue, offsetAxis);
    }
}