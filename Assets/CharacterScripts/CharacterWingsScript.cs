using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWingsScript : MonoBehaviour
{
    GameObject characterLeftWing, characterRightWing;
    float mouseZ = 0, mouseX = 0, velocity = 70f, currentRightZRotation = 0, currentLeftZRotation = 0, currentRightXRotation = 0, currentLeftXRotation = 0;
    public CharacterScript player;
    // Start is called before the first frame update
    void Start()
    {
        characterLeftWing = GameObject.Find("characterLeftWing");
        characterRightWing = GameObject.Find("characterRightWing");
        player = FindObjectOfType<CharacterScript>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Input.GetAxis("leftStick"));

        if (Input.GetButtonUp("rightClick"))
        {
            player.velocityUp += (Mathf.Sin(currentRightZRotation * Mathf.Deg2Rad)) * 50 * Time.deltaTime;
            characterRightWing.transform.localRotation = Quaternion.Euler(0, 0, 0);
            currentRightZRotation = 0;
            currentRightXRotation = 0;

        }
        if (Input.GetButtonUp("leftClick"))
        {
            player.velocityUp += -1 * (Mathf.Sin(currentLeftZRotation * Mathf.Deg2Rad)) * 50 * Time.deltaTime;
            characterLeftWing.transform.localRotation = Quaternion.Euler(0, 0, 0);
            currentLeftZRotation = 0;
            currentLeftXRotation = 0;
        }

        if (Input.GetButton("leftClick") && Input.GetButton("rightClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");
            mouseX = Input.GetAxis("Mouse Y");

            characterLeftWing.transform.localRotation = Quaternion.Euler(new Vector3(currentLeftXRotation + mouseX * velocity * Time.deltaTime, 0, currentLeftZRotation + mouseZ * velocity * Time.deltaTime));
            currentLeftZRotation += mouseZ * velocity * Time.deltaTime;
            currentLeftXRotation += mouseX * velocity * Time.deltaTime;

            characterRightWing.transform.localRotation = Quaternion.Euler(new Vector3(currentRightXRotation + mouseX * velocity * Time.deltaTime, 0, currentRightZRotation + mouseZ * -1 * velocity * Time.deltaTime));
            currentRightZRotation += -1 * mouseZ * velocity * Time.deltaTime;
            currentRightXRotation += mouseX * velocity * Time.deltaTime;
        }

        else if (Input.GetButton("rightClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");
            mouseX = Input.GetAxis("Mouse Y");

            characterRightWing.transform.localRotation = Quaternion.Euler(new Vector3(currentRightXRotation + mouseX * velocity * Time.deltaTime, 0, currentRightZRotation + mouseZ * velocity * Time.deltaTime));
            currentRightZRotation += mouseZ * velocity * Time.deltaTime;
            currentRightXRotation += mouseX * velocity * Time.deltaTime;
        }
        else if (Input.GetButton("leftClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");
            mouseX = Input.GetAxis("Mouse Y");

            characterLeftWing.transform.localRotation = Quaternion.Euler(new Vector3(currentLeftXRotation + mouseX * velocity * Time.deltaTime, 0, currentLeftZRotation + mouseZ * velocity * Time.deltaTime));
            currentLeftZRotation += mouseZ * velocity * Time.deltaTime;
            currentLeftXRotation += mouseX * velocity * Time.deltaTime;
        }
        
    }
}
