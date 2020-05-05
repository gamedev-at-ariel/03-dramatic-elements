using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag,
 * and additionally instantiates an explosion effect.
 */
public class DestroyOnTriggerWithEffect: DestroyOnTrigger2D {
    [Tooltip("This effect will be shown when the object is destroyed.")]
    [SerializeField] GameObject effectPrefab = null;
    [SerializeField] float effectDuration = 1;

    protected override void DestroyCurrentObject() {
        // Previous version:
        // Destroy(this.gameObject);
        StartCoroutine(ActivateDestructionEffect());
    }

    IEnumerator ActivateDestructionEffect() {
        this.GetComponent<SpriteRenderer>().enabled = false;  // hide this object for the duration of the effect
        var effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
        effect.transform.parent = this.transform;  // the effect is a child of this object, so that it is automatically destroyed when this object is destroyed.
        yield return new WaitForSeconds(effectDuration);
        Destroy(this.gameObject);
    }
}
