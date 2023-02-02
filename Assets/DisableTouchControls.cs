using UnityEngine;
using Cinemachine;

public class DisableTouchControls : MonoBehaviour
{

    public CinemachineFreeLook freeLookCamera;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

    private void Update()
    {
        float x = Input.GetAxis(horizontalAxis);
        float y = Input.GetAxis(verticalAxis);

        freeLookCamera.m_XAxis.Value = x;
        freeLookCamera.m_YAxis.Value = y;
    }
}