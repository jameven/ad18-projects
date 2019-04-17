using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject templateGingerbread;
    public GameObject[] spawnPoints;
    public float spawnTargetTime = 5f;
    private float spawnElapsedTime = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (spawnElapsedTime >= spawnTargetTime) {
            Spawn();
            spawnElapsedTime = 0f;
        }
        spawnElapsedTime = spawnElapsedTime + Time.deltaTime;
        Debug.Log("elapsed=" + spawnElapsedTime);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Spawn();
        }	
	}

    private void Spawn() {
        int random = Random.Range(0, spawnPoints.Length);
        GameObject gingerbread = Instantiate(templateGingerbread);
        gingerbread.transform.position = spawnPoints[random].transform.position;
    }
}
