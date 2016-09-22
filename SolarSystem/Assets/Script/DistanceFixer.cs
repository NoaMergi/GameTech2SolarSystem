using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceFixer : MonoBehaviour 
{

    public float scale = 1.0f;
    public Slider mainSlider;
    ParametricPath[] parametricPath;
	// Use this for initialization
	void Start () 
    {

        //originalScale = new Vector2(parametricPath[i].A, parametricPath[i].B);
        parametricPath = FindObjectsOfType<ParametricPath>();

	}
	

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        scale = mainSlider.value;

        for (int i = 0; i < parametricPath.Length; i++)
        {

            parametricPath[i].scaledA = parametricPath[i].getA() * scale;
            parametricPath[i].scaledB = parametricPath[i].getB() * scale;
        }
    }


}
