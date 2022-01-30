using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire 2"))
            anim.SetBool("attacking", true);
        else if (Input.GetButtonUp("Fire 2"))
            anim.SetBool("attacking", false);
    }
}
