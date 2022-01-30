using UnityEngine;

public class PewPew : MonoBehaviour
{
	public float pewPewPerSecond = 11f;

	private float lifetime;

	// Update is called once per frame
	private void Update()
	{
		lifetime += Time.deltaTime * pewPewPerSecond;
		if (lifetime >= 1) Destroy(gameObject);
	}
}