using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerAndroid : MonoBehaviour
{
    public Player player;

    void Update()
    {
		for (var i = 0; i < Input.touchCount; ++i)
		{
			//Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
			//RaycastHit hit;
			//if (Physics.Raycast(ray, out hit))
			//{
			//	if (hit.transform.tag == "Player")
			//	{


			//	}

			//}
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				player.BeginExcretionMass();
			}
			else if (Input.GetTouch(i).phase == TouchPhase.Ended)
			{
				player.BallThrow();
			}
			else if (Input.GetTouch(i).phase == TouchPhase.Stationary)
			{
				player.ExcretionMass();
			}
		}
	}
}
