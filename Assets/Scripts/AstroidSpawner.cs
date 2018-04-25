using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidSpawner : MonoBehaviour
{
    public GameObject astroid;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;

    // Use this for initializationc``
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            float random = Random.Range(-2f, 2f);
            Instantiate(astroid, new Vector3(random,5.5f, 0), Quaternion.identity);
            elapsedTime = 0;
        }

    }
}
