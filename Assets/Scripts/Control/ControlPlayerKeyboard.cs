using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerKeyboard : MonoBehaviour
{
    public Player player;

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			player.BeginExcretionMass();
		}
		else if (Input.GetKeyUp(KeyCode.Mouse0))
		{
			player.BallThrow();
		}
		else if (Input.GetKey(KeyCode.Mouse0))
		{
			player.ExcretionMass();
		}
	}
}
