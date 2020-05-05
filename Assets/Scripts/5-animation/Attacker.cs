using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component sets its object to "attack" mode whenever the player hits the given key.
 */
public class Attacker : MonoBehaviour {
    [Tooltip("What key should the player press in order to go to attack mode")] [SerializeField] KeyCode attackKey = KeyCode.Space;
    [Tooltip("How many seconds the object remains in attack mode")] [SerializeField] float attackDuration = 1f;

    private Animator animator = null;
    private Mover mover = null;

    void Start() {
        animator = GetComponent<Animator>();
        mover = GetComponent<Mover>();
    }

    void Update() {
        if (Input.GetKey(attackKey)) {
            StartCoroutine(GoToAttackMode());
        }
    }

    IEnumerator GoToAttackMode() {
        mover.enabled = false;
        animator.SetBool("IsAttacking", true);  // changes the animation to "Attack"
        yield return new WaitForSeconds(attackDuration);
        animator.SetBool("IsAttacking", false); // changes the animation back to "Walk"
        mover.enabled = true;
    }
}
