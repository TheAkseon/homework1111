﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGeneration : MonoBehaviour {

	[SerializeField] private GameObject _template;
	[SerializeField] private float _secondsBetweenSpawn;
	[SerializeField] private float _maxSpawnPositionY;
	[SerializeField] private float _minSpawnPositionY;
	[SerializeField] private GameObject _spawner;


	private float _spawnPositionX = 10;
	private float _spawnPositionY = 0;

	private float _elapsedTime = 0;



	void Update () 
	{
		_elapsedTime += Time.deltaTime;

		if (_elapsedTime > _secondsBetweenSpawn) 
		{
			_elapsedTime = 0;
			_spawnPositionX += 5;
			_spawnPositionY = Random.Range (_minSpawnPositionY, _maxSpawnPositionY);
			Vector3 spawnPoint = new Vector3 (_spawnPositionX, _spawnPositionY, transform.position.z);
			Instantiate (_template, spawnPoint, Quaternion.identity);
		}

	}
}
