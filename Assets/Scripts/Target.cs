using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float health = 100f;
    public MeshRenderer meshRenderer;

    public bool IsDead { get; private set; }



    private void Die()
    {

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
