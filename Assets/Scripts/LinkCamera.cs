using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    void LateUpdate()
    {
        transform.rotation = target.rotation;
    }
}
