using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRightWingScript : MonoBehaviour
{
    GameObject characterRightWing, characterLeftWing;
    float mouseZ = 0, velocity = 70f, currentRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        characterRightWing = GameObject.Find("characterRightWing");
        characterLeftWing = GameObject.Find("characterLeftWing");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("rightClick") && Input.GetButton("leftClick"))
        {
            mouseZ = -1 * Input.GetAxis("Mouse X");

            characterRightWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRotation + mouseZ * velocity * Time.deltaTime));
            currentRotation += mouseZ * velocity * Time.deltaTime;

            characterLeftWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRotation + mouseZ * velocity * Time.deltaTime));
            currentRotation += mouseZ * velocity * Time.deltaTime;
        }
        else if (Input.GetButton("rightClick"))
        {
            characterRightWing.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, currentRotation + mouseZ * velocity * Time.deltaTime));
            currentRotation += mouseZ * velocity * Time.deltaTime;
        }
    }
}
