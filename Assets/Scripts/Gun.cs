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
    void Update()
    {
        if (inputs.shoot)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            var target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(10);
            }
        }
    }
}
