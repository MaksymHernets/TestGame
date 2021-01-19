using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
	public delegate void RoadClear();
	public event RoadClear RoadClearEvent;

	private int CountBlock = 1;

	private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "capsule")
			++CountBlock;
	}

	private void FixedUpdate()
	{
		if (CountBlock == 0 && RoadClearEvent != null)
			RoadClearEvent();
		CountBlock = 0;
	}
}
