﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public bool isEndDoor = false;
	public int levelToLoad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if ((other.tag == "Player") && isEndDoor) {
			SceneManager.LoadScene (levelToLoad);
		}
	}
}
