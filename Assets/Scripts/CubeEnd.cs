using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnd : MonoBehaviour
{
    public GameObject door;
	private bool IsOpen = false;

	private void OnTriggerEnter(Collider other)
	{
		if ( other.gameObject.tag == "Player")
		{
			if (IsOpen == false)
			{
				IsOpen = true;
				StartCoroutine(DoorOpen());
			} 
		}
	}

	IEnumerator DoorOpen()
	{
		for (int i = 0; i < 51; ++i)
		{
			door.transform.localPosition -= new Vector3(0, 0.02f, 0);
			yield return new WaitForSeconds(0.03f);
		}
	}
}
