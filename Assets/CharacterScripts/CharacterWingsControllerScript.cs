using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWingsControllerScript : MonoBehaviour
{
    GameObject character, leftWing, rightWing;
    public float prevLSX = 0, prevLSZ = 0, prevRSX = 0, prevRSZ = 0, leftStickX  = 0, rightStickX = 0, leftStickZ = 0, rightStickZ = 0, L2 = 0, R2 = 0, dampening = 5, maxAngle = 70;
    public CharacterScript player;

    public void LeftMovement()
    {
        leftStickX = Input.GetAxis("leftStickY");
        leftStickZ = Input.GetAxis("leftStickX");

        float targetLeftX = leftStickX * maxAngle;
        float targetLeftZ = leftStickZ * maxAngle;

        Quaternion leftTargetRotation = Quaternion.Euler(targetLeftX, 0, targetLeftZ);

        leftWing.transform.localRotation = Quaternion.Lerp(leftWing.transform.localRotation, leftTargetRotation, dampening * Time.deltaTime);

        if (prevLSZ - leftStickZ < 0)
        player.velocityUp += (maxAngle * (leftStickZ - prevLSZ) * Time.deltaTime);

        prevLSX = leftStickX;
        prevLSZ = leftStickZ;
    }

    public void RightMovement()
    {
        rightStickX = Input.GetAxis("rightStickY");
        rightStickZ = Input.GetAxis("rightStickX");

        float targetRightX = rightStickX * maxAngle;
        float targetRightZ = rightStickZ * maxAngle;

        Quaternion rightTargetRotation = Quaternion.Euler(targetRightX, 0, targetRightZ);

        rightWing.transform.localRotation = Quaternion.Lerp(rightWing.transform.localRotation, rightTargetRotation, dampening * Time.deltaTime);

        if (prevRSZ - rightStickZ > 0)
        player.velocityUp += (-1 * maxAngle * (rightStickZ - prevRSZ) * Time.deltaTime);

        prevRSX = rightStickX;
        prevRSZ = rightStickZ;
    }

    public void Dive()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("testCharatcer");
        leftWing = GameObject.Find("characterLeftWing");
        rightWing = GameObject.Find("characterRightWing");
        player = FindObjectOfType<CharacterScript>();

    }

    // Update is called once per frame
    void Update()
    {
        LeftMovement();
        RightMovement();
        Dive();
    }
}
