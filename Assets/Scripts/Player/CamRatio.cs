using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRatio : MonoBehaviour
{
    private void Awake()
    {
        Camera cam = GetComponent<Camera>();
        cam.aspect = 1.0f;

        float screenRatio = (float)Screen.height / Screen.width;
        //float widthRatio = (screenRatio > 1.0f) ? 1.0f : screenRatio;

        float x = (1 - screenRatio) / 2;

        cam.rect = new Rect(x, 0, screenRatio, 1f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
            
    }
}
