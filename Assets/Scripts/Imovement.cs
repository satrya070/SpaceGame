using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Imovement
{
    float YawAmount { get; }
    float pitchAmount { get; }
    float rollAmount { get; }
    float thrustAmount { get; }
}
