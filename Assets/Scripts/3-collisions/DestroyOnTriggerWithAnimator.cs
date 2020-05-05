using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag,
 * and additionally invokes a state-transition in this object's animator.
 */
public class DestroyOnTriggerWithAnimator: DestroyOnTrigger2D {
    [Tooltip("The parameter with this name should be set to 'true' when the object is destroyed.")]
    [SerializeField] string animatorParameterName;

    protected override void DestroyCurrentObject() {
        GetComponent<Animator>().SetBool(animatorParameterName, true);
        // In the animation, there is an event that triggers the method "DestroyCurrentObjectAfterAnimation" below.
    }

    public void DestroyCurrentObjectAfterAnimation() {
        Destroy(this.gameObject);
    }
}
