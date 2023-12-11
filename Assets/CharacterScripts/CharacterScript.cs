using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    GameObject Character;
    public float velocityUp = 1, velocityForward = 20, airResistance = 1.5f;
    public CharacterWingsScript wings;
    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("testCharacter");

        wings = FindObjectOfType<CharacterWingsScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Character.transform.Translate(Vector3.up * velocityUp * Time.deltaTime);
        Character.transform.Translate(Vector3.forward * velocityForward * Time.deltaTime);
        velocityUp -= airResistance * Time.deltaTime;
    }
}
