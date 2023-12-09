using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    GameObject Character;
    float velocity = 2, acceleration = 0;
    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("testCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        Character.transform.Translate(Vector3.forward * velocity * Time.deltaTime);
    }
}
