using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "capsule")
		{
			var massCollider = Physics.OverlapSphere(this.transform.localPosition, this.transform.localScale.x * 2f);
			for (int i = 0; i < massCollider.Length; ++i)
			{
				if (massCollider[i].gameObject.tag == "capsule")
				{
					massCollider[i].gameObject.SendMessage("Dispose", SendMessageOptions.DontRequireReceiver);
				}
			}
			collision.gameObject.SendMessage("Dispose");
		}
		if(collision.gameObject.tag != "bullet")
		{
			Dispose();
		}
	}

	public void Dispose()
	{
		var rigidbody = this.gameObject.GetComponent<Rigidbody>();
		rigidbody.isKinematic = true;
		rigidbody.isKinematic = false;
		this.gameObject.SetActive(false);
	}
}
