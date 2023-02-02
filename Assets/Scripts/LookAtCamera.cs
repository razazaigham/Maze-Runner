using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    Camera cam;
    
    void Start()
    {
        cam = Camera.main;
        Canvas canvas = GetComponent<Canvas>();
        canvas.renderMode = RenderMode.WorldSpace;
    }

    private void Update()
    {
        transform.LookAt(cam.transform);
        transform.Rotate(Vector3.up, 180f);
    }
}
