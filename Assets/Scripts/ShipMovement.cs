using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] ShipControlInput movementInput;
    [SerializeField] [Range(1000f, 10000f)]
    float thrustForce = 7500f,
          pitchForce = 6000f,
          rollForce = 1000f,
          yawForce = 2000f;

    Rigidbody rigidBody;
    [SerializeField][Range(-1f, 1f)]
    float thrustAmount, pitchAmount, rollAmount, yawAmount = 0f;

    Imovement ControlInput => movementInput.movementControls;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Start()
    {
    }

    void Update()
    {
        thrustAmount = ControlInput.thrustAmount;
        rollAmount = ControlInput.rollAmount;
        yawAmount = ControlInput.YawAmount;
        pitchAmount = ControlInput.pitchAmount;
    }

    void FixedUpdate()
    {
        if (!Mathf.Approximately(0f, pitchAmount))
        {
            rigidBody.AddTorque(transform.right * (pitchForce * pitchAmount * Time.deltaTime));
        }

        if (!Mathf.Approximately(0f, rollAmount))
        {
            rigidBody.AddTorque(transform.forward * (rollForce * rollAmount * Time.deltaTime));
        }

        if (!Mathf.Approximately(0f, yawAmount))
        {
            rigidBody.AddTorque(transform.up * (yawForce * yawAmount * Time.deltaTime));
        }

        if(!Mathf.Approximately(0f, thrustAmount))
        {
            rigidBody.AddForce(transform.forward * (thrustForce * thrustAmount * Time.deltaTime));
        }
    }
}
