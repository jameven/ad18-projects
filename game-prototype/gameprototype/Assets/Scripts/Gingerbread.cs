﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gingerbread : MonoBehaviour {

    private GameObject player;

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update () {
        //transform.LookAt(player.transform);
        transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
    }
    
}
