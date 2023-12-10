using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWingsScript : MonoBehaviour
{
    GameObject characterLeftWing, characterRightWing;
    float mouseZ = 0, velocity = 70f, currentRightRotation = 0, currentLeftRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        characterLeftWing = GameObject.Find("characterLeftWing");
        characterRightWing = GameObject.Find("characterRightWing");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("leftClick") && Input.GetButton("rightClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");

            characterLeftWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentLeftRotation + mouseZ * velocity * Time.deltaTime));
            currentLeftRotation += mouseZ * velocity * Time.deltaTime;

            characterRightWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRightRotation + mouseZ * -1 * velocity * Time.deltaTime));
            currentRightRotation += -1 * mouseZ * velocity * Time.deltaTime;
        }

        else if (Input.GetButton("rightClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");

            characterRightWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRightRotation + mouseZ * velocity * Time.deltaTime));
            currentRightRotation += mouseZ * velocity * Time.deltaTime;
        }
        else if (Input.GetButton("leftClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");

            characterLeftWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentLeftRotation + mouseZ * velocity * Time.deltaTime));
            currentLeftRotation += mouseZ * velocity * Time.deltaTime;
        }
        
    }
}
