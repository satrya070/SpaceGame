using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[Serializable]
public class DesktopControls : ControlsBase
{
    [SerializeField] float deadRadius = 0.1f;
    Vector2 ScreenCenter => new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

    public override float YawAmount
    {
        get
        {
            Vector3 mousePosition = Input.mousePosition;
            float yaw = (mousePosition.x - ScreenCenter.x) / ScreenCenter.x;
            return Mathf.Abs(yaw) > deadRadius ? yaw : 0f;
        }
    }

    public override float pitchAmount
    {
        get
        {
            Vector3 mousePosition = Input.mousePosition;
            float pitch = (mousePosition.y - ScreenCenter.y) / ScreenCenter.y;
            return Mathf.Abs(pitch) > deadRadius ? pitch * -1: 0f;
        }
    }

    public override float rollAmount
    {
        get
        {
            if (Input.GetKey(KeyCode.Q))
            {
                return 1;
            }

            return Input.GetKey(KeyCode.E) ? -1f : 0f;
        }
    }

    public override float thrustAmount => Input.GetAxis("Vertical");
}
