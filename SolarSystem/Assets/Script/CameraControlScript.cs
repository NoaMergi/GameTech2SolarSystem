using UnityEngine;
using System.Collections.Generic;

public class CameraControlScript : MonoBehaviour 
{

   public List<Camera> cameras;

	// Use this for initialization
	void Start () 
    {
        unableCameras();
        cameras[0].enabled = true;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.anyKeyDown)
        {
            
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                unableCameras();
                cameras[0].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                unableCameras();
                cameras[1].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                unableCameras();
                cameras[2].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                unableCameras();
                cameras[3].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                unableCameras();
                cameras[4].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                unableCameras();
                cameras[5].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                unableCameras();
                cameras[6].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                unableCameras();
                cameras[7].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                unableCameras();
                cameras[8].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                unableCameras();
                cameras[9].enabled = true;
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    void unableCameras()
    {
        foreach (var camera in cameras)
        {
            camera.GetComponent<Camera>().enabled = false;
        }
    }
}
