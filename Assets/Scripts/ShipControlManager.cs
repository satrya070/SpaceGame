using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControlManager : MonoBehaviour
{
    public enum InputType
    {
        HumanDesktop,
        HumanMobile,
        Bot
    }

    public static Imovement GetInputcontrols(InputType inputType)
    {
        return inputType switch
        {
            InputType.HumanDesktop => new DesktopControls(),
            InputType.HumanMobile => null,
            InputType.Bot => null,
            _ => throw new ArgumentOutOfRangeException(nameof(inputType), inputType, null)
        };
    }
}
