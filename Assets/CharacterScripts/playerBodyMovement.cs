using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBodyMovement : MonoBehaviour
{
    Rigidbody rig;
    public float R2, L2;
    public float acc = 0, counterAcc = 0, lx = 0, rx = 0, ly = 0, ry = 0;
    public float steer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        //rig.AddForce(Vector3.forward * 1 * Time.deltaTime, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        lx = Input.GetAxis("leftStickX");
        rx = Input.GetAxis("rightStickX");

        this.transform.Rotate(Vector3.forward, lx * 35);
        this.transform.rotation = Quaternion.Euler(0, -50 * lx, lx * 35);

    }

    private void FixedUpdate()
    {
        R2 = Input.GetAxis("RT");
        L2 = Input.GetAxis("LT");
        //lx = Input.GetAxis("leftStickX");
        //rx = Input.GetAxis("rightStickX");
        ly = Input.GetAxis("leftStickY");
        ry = Input.GetAxis("rightStickY");

        steer = lx * 20;

        if (R2 == 0)
        {
            acc = 0;
        }
        else
        {
            acc = 20;
        }

        if (L2 == 0)
        {
            rig.drag = 0.07f;
        }
        else
        {
            rig.drag = 0.7f * L2; 
        }

        rig.AddRelativeForce(Vector3.forward * acc, ForceMode.Acceleration);
    }
}
