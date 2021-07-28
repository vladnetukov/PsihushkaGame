using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour {

    public GameObject platformPrefab;
	// Use this for initialization
	void Start () {

        Vector3 SpawnerPosition = new Vector3();
        for(int i = 0; i < 10; i++)
        {
            SpawnerPosition.x = Random.Range(-2.4f, 2.4f);
            SpawnerPosition.y += Random.Range(2f, 4f);
            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
