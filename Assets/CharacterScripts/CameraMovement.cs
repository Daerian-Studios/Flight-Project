using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    GameObject Camera;
    GameObject Character;
    float xOffset = 0f, zOffset = -12f, yOffset = 1.6f;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Main Camera");
        Character = GameObject.Find("testCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = Character.transform.position + new Vector3(xOffset, yOffset, zOffset);
    }
}
