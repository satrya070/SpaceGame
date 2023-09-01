using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    public Transform shipPosition;
    Vector3 cameraOrientation = new Vector3 (0, 0, -20f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move cam 5 above, 20 back behind ship for 3rd view
        transform.position = (shipPosition.position + shipPosition.up * 5) + (-shipPosition.forward * 20);
        transform.rotation = shipPosition.rotation;
        Debug.Log(shipPosition.forward);
    }
}
