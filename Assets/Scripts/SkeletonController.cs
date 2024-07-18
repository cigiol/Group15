using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour
{
    public float attackRange;
    CapsuleCollider myCollider;
    Animator animator;
    private GameObject player;
    public bool isAttacking = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        myCollider = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        CheckPlayer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isAttacking)
        {
            Debug.Log("Hit");
        }
    }

    private void CheckPlayer()
    {
        //TODO: Check if player enough to attack our range.
        if ((player.transform.position - transform.position).magnitude < attackRange)
            Attack();

    }

    private void Attack()
    {
        if (!animator.GetBool("isNear"))
        {
            //myCollider.radius = 2.5f;
            Vector3 targetPosition = new Vector3(player.transform.position.x, transform.transform.position.y, player.transform.position.z);
            transform.LookAt(targetPosition);
            animator.SetBool("isNear", true);
            StartCoroutine(StopAttack(1.15f));
            StartCoroutine(StopAttackAnimation("isNear", 1f));
            if (myCollider.radius == 0f)
            {
                StartCoroutine(Hit(0.6f));

            }
        }
        //TODO: after making this trigger true , set false after 1.25 sec.

    }

    IEnumerator Hit(float sec)
    {
        yield return new WaitForSeconds(sec);
        myCollider.radius = 1.5f;
        isAttacking = true;

    }

    IEnumerator StopAttackAnimation(string key, float sec)
    {
        yield return new WaitForSeconds(sec);
        animator.SetBool(key, false);
    }

    IEnumerator StopAttack(float sec)
    {
        yield return new WaitForSeconds(sec);
        myCollider.radius = 0f;
        isAttacking = false;

    }
}
