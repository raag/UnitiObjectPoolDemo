using UnityEngine;

public class PooledObject : MonoBehaviour
{
	public ObjectPool owner;
}


public static class PooledGameObjectExtensions
{
	public static void ReturnToPool(this GameObject gameObject)
	{
		var pooledObject = gameObject.GetComponent<PooledObject>();
		if (pooledObject == null)
		{
			Debug.LogError("Object " + gameObject.name + " wasn't created from a pool and can't be returned to one.");
			return;
		}
		pooledObject.owner.ReturnObject(gameObject);
	}
}