using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_on : NewBehaviourScript
{
    private Animator anim;
    private BoxCollider2D boxCollider;

    private bool isWorking = true;
    [SerializeField] private float cooldown;
    private float cooldownTimer;

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer < 0)
        {
            isWorking = !isWorking;
            cooldownTimer = cooldown;
            if (isWorking == true)
            {
                gameObject.tag = "Trap";
                boxCollider.enabled = true;
            }
            if (isWorking == false)
            {
                gameObject.tag = "Untagged";
                boxCollider.enabled = false;

            }
        }
        anim.SetBool("isWorking", isWorking);
    }
}