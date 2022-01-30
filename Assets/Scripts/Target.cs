using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float health = 100f;
    public MeshRenderer meshRenderer;
    public Material materialOfDeath;

    public bool IsDead { get; private set; }



    private void Die()
    {
        meshRenderer.material = materialOfDeath;
        IsDead = true;
        GetComponent<MeshDestroy>()?.DestroyMesh();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();

        }
    }


}
