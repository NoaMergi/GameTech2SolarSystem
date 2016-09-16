using UnityEngine;

public class RotationScript : MonoBehaviour
{

    //6.963


    public bool IsClockwise = true;
    public float RotationPeriodInHours = 24f;
    public Vector3 offsetAxis;
    public float offsetValue;

    private const float timescale = 1f;

    //Rotation progress between 0 and 1
    private float currentTime = 0f;

    void Update()
    {
        Debug.Log((Time.deltaTime * timescale / RotationPeriodInHours).ToString("F9"));
        currentTime += Time.deltaTime * timescale / RotationPeriodInHours;
        currentTime %= 1.0f;

        float currentRotationAngle = currentTime * 360f;

        if( !IsClockwise )
        {
            currentRotationAngle *= -1f;
        }

        transform.rotation = Quaternion.AngleAxis( currentRotationAngle, Vector3.up );
        transform.Rotate(offsetAxis);
        //transform.rotation = Quaternion.AngleAxis(offsetValue, offsetAxis);
    }
}