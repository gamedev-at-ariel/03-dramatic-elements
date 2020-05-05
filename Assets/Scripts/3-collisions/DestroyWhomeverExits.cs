using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys any object that exits its collider.
 */
public class DestroyWhomeverExits: MonoBehaviour {
    private void OnTriggerExit2D(Collider2D other) {
        Destroy(other.gameObject);
    }
}
