using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float health = 100f;
    public MeshRenderer meshRenderer;
    public Material materialOfDeath;



    private void Die()
    {
        meshRenderer.material = materialOfDeath;
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
