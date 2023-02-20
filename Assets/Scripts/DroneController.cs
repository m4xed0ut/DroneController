using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class DroneController : MonoBehaviour
{
    public GameObject drone;
    private float throttleSpeed = 5;
    private float fallSpeed = 5; 
    public Transform targetUp;

    void Update()
    {
        Throttle();
        Pitch();
        Roll();
        Yaw();
    }

    void Throttle()
    {
        if (Gamepad.current != null && Gamepad.current.leftStick.y.IsActuated(1))
        {
            drone.GetComponent<Rigidbody>().AddForce(targetUp.transform.up * throttleSpeed);
        }
        else
        {
            drone.GetComponent<Rigidbody>().AddForce(Vector3.down * fallSpeed);
        }

    }
    void Yaw()
    {
        drone.transform.Rotate(0, Gamepad.current.leftStick.x.ReadValue(), 0, Space.Self);
    }

    void Pitch()
    {
        drone.transform.Rotate(Gamepad.current.rightStick.y.ReadValue(), 0, 0, Space.Self);
    }

    void Roll()
    {
        drone.transform.Rotate(0, 0, -Gamepad.current.rightStick.x.ReadValue(), Space.Self);

    }

}
