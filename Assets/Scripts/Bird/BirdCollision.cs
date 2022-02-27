using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Bird))]
public class BirdCollision : MonoBehaviour 
{
	private Bird _bird;


	void Start()
	{
	_bird = GetComponent<Bird>();
	}
	
	
		private void OnTriggerEnter2D(Collider2D collision)
	{
		_bird.Die();
	}
}
