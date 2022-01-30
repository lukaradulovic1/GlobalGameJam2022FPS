using StarterAssets;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public GameObject pewPewPrefab;
	public float damage = 10f;
	public float range = 100f;
	public StarterAssetsInputs inputs;
	public Camera fpsCam;

	// Update is called once per frame
	private void Update()
	{
		if (inputs.shoot) Shoot();
	}

	private void Shoot()
	{
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out var hit, range))
		{
			var target = hit.transform.GetComponent<Target>();
			if (target != null)
			{
				target.TakeDamage(10);
				if (!target.IsDead) Debug.Log(hit.transform.name);
			}
		}
	}
}