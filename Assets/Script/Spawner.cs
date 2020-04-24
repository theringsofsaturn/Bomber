using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject bomb;

	private float minX = -4.6f;
	private float maxX = 4.6f;



	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnBombs());
		
	}

	IEnumerator SpawnBombs()
	{
		yield return new WaitForSeconds(Random.Range(0f, 1f));

		Instantiate(bomb, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity); //Quaternion.identity dmth 0 per cdo kend rotacioni (angle)

		StartCoroutine(SpawnBombs());
	}
	
	


} //class




















