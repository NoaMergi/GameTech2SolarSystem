using UnityEngine;

public class RotationScript : MonoBehaviour
{

    //6.963


    public bool isClockwise = true;
    public float rotationPeriodInHours = 24f;
    public Vector3 offsetAxis;
    public Vector3 rotationAxis = Vector3.up;

    private const float timescale = 1f;

    //Rotation progress between 0 and 1
    private float currentTime = 0f;

    void Update()
    {
        Debug.Log((Time.deltaTime * timescale / rotationPeriodInHours).ToString("F9"));
        currentTime += Time.deltaTime * timescale / rotationPeriodInHours;
        currentTime %= 1.0f;

        float currentRotationAngle = currentTime * 360f;

        if( !isClockwise )
        {
            currentRotationAngle *= -1f;
        }

        transform.rotation = Quaternion.AngleAxis( currentRotationAngle, rotationAxis);
        transform.Rotate(offsetAxis);
        //transform.rotation = Quaternion.AngleAxis(offsetValue, offsetAxis);
    }
}