using System.Collections;
using UnityEngine;

public class MyCapsule : MonoBehaviour
{
	private bool IsDie = false;

    public void Dispose()
	{
		gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		if (IsDie == false)
		{
			IsDie = true;
			StartCoroutine(Animation_Destroy());
		}
	}

	IEnumerator Animation_Destroy()
	{
		for (int i = 30; i >= 0; --i)
		{
			float value = i * 0.01f;
			this.transform.localScale = new Vector3(value, value , value);
			yield return new WaitForSeconds(0.01f);
		}
		Destroy(this.gameObject);
	}
}
