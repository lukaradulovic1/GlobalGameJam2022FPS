using UnityEngine;

public class Target : MonoBehaviour
{
	private float health = 100f;

	public bool IsDead { get; private set; }

	private void Die()
	{
		IsDead = true;
		GetComponent<MeshDestroy>()?.DestroyMesh();
	}

	public void TakeDamage(float damage)
	{
		health -= damage;
		if (health <= 0) Die();
	}
}