using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject templateGingerbread;
    public GameObject[] spawnPoints;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            int random = Random.Range(0, spawnPoints.Length);
            GameObject gingerbread = Instantiate(templateGingerbread);
            gingerbread.transform.position = spawnPoints[random].transform.position;
        }	
	}
}
