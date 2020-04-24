using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour {

	public Text scoreText;
	private int score = 0;

	void IncreaseScore()
	{
		score++;

		scoreText.text = "Pikët: " + score;
	}

	void OnTriggerEnter2D(Collider2D target)
	{

		if(target.tag == "Bomb") //Prandaj e bejme tag "Bomb" tek Prefabs. 
		{
			IncreaseScore();
			target.gameObject.SetActive(false); 
		}
	}
}
