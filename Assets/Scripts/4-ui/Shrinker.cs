using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component allows its object to shrink temporarily.
 */
public class Shrinker : MonoBehaviour {
    [SerializeField] float shrinkFactor = 2;
    [SerializeField] float shrinkDuration = 1;

    private Vector3 originalScale;
    private void Start() {
        originalScale = transform.localScale;
    }

    public void Shrink() {
        StartCoroutine(ShrinkTemporarily());
    }

    private IEnumerator ShrinkTemporarily() {
        transform.localScale = originalScale  /  shrinkFactor;
        yield return new WaitForSeconds(shrinkDuration);
        transform.localScale = originalScale;
    }
}
