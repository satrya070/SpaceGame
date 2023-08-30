using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControlInput : MonoBehaviour
{
    [SerializeField] ShipControlManager.InputType controlSystem = ShipControlManager.InputType.HumanDesktop;
    public Imovement movementControls { get; private set; }

    void Start()
    {
        movementControls = ShipControlManager.GetInputcontrols(controlSystem);
    }

    void OnDestroy()
    {
        movementControls = null;
    }
}
