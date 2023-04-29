using System.Collections;
using UnityEngine;

public class ReturnAfterDelay : MonoBehaviour, IObjectPoolNotifier
{
	public void OnCreatedOrDequeuedFromPool(bool created)
	{
		Debug.Log("Dequeued from pool");
		StartCoroutine(DoReturnAfterDelay());
	}

	public void OnEnqueuedToPool()
	{
		Debug.Log("Enqueued to pool");
	}

	IEnumerator DoReturnAfterDelay()
	{
		yield return new WaitForSeconds(1);
		gameObject.ReturnToPool();
	}
}
