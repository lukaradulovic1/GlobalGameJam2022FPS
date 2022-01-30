using StarterAssets;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public GameObject pewPewPrefab;
	public Transform pewPewHolder;
	public float damage = 10f;
	public float range = 100f;
	public StarterAssetsInputs inputs;
	public Camera fpsCam;
	public float shotsPerSecond = 10f;

	private float shotCooldownProgress;

	// Update is called once per frame
	private void FixedUpdate()
	{
		shotCooldownProgress += Time.deltaTime * shotsPerSecond;
		if (inputs.shoot) Shoot();
	}

	private void Shoot()
	{
		if (shotCooldownProgress < 1f) return;

		shotCooldownProgress = 0;
		Instantiate(pewPewPrefab, pewPewHolder);
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out var hit, range))
		{
			var target = hit.transform.GetComponent<Target>();
			if (target != null)
			{
				target.TakeDamage(damage);
				if (!target.IsDead) Debug.Log($"{hit.transform.name} took 10 damage");
			}
		}
	}
}