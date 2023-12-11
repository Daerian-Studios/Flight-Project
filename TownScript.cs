using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownScript : MonoBehaviour
{
    GameObject town, character;
    GameObject generatedObject1;
    GameObject objectToCreate;
    public bool generateOnStart = true;
    Vector3 spawnPosition1, newSpawnPosition;
    float newSpawnPositionZ = 56.2f;
    Quaternion spawnRotation1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start method called");

        town = GameObject.Find("townNotScripted");
        character = GameObject.Find("testCharacter");

        spawnPosition1 = new Vector3(27.08f, -5.3f, 56.2f);
        spawnRotation1 = Quaternion.identity;

        if (generateOnStart)
        {
            generateOnStart = false;
            generatedObject1 = Instantiate(town, spawnPosition1, spawnRotation1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(character.transform.position.z >= newSpawnPositionZ)
        {
            newSpawnPosition = new Vector3(27.08f, -5.3f, newSpawnPositionZ+56.2f);
            objectToCreate = Instantiate(town, newSpawnPosition, spawnRotation1);

            newSpawnPositionZ += 56.2f;
        }
    }
}
