using UnityEngine;

public class PewPew : MonoBehaviour
{
	public float durationSeconds = 0.05f;

	private float lifetime;

	// Update is called once per frame
	private void Update()
	{
		lifetime += Time.deltaTime / durationSeconds;
		if (lifetime >= 1) Destroy(gameObject);
	}
}