using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlsBase : Imovement
{
    public abstract float YawAmount { get; }

    public abstract float pitchAmount { get; }

    public abstract float rollAmount { get; }

    public abstract float thrustAmount { get; }
}
