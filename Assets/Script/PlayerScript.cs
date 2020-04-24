using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float speed = 10f;

	private float minX = -4.6f;
	private float maxX = 4.6f;

	
	
	
	void Update () {

		MovePlayer();
	}

	void MovePlayer()
	{
		float h = Input.GetAxis("Horizontal");
		Vector2 currentPosition = transform.position;

		if (h > 0)
		{
			//Shkon nga ana e majte

			currentPosition.x += speed * Time.deltaTime;
			// eshte njesoj si >> temp.x = temp.x + speed * Time.deltaTime;

		} else if (h < 0)
		{
			//Shkon nga ana e djathte

			currentPosition.x -= speed * Time.deltaTime;

		}

		// Nqs shkohet me shume se limiti qe kam vendos majtas currentPosition do jete minX, dmth e ndalon aty
		if (currentPosition.x < minX)
		{
			currentPosition.x = minX;
		}

		if (currentPosition.x > maxX)
		{
			currentPosition.x = maxX;
		}

		transform.position = currentPosition;
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if(target.tag == "Bomb")
		{
			Time.timeScale = 0f;
		}
	}

} //class



















