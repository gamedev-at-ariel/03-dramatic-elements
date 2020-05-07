using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component teleports any object that triggers it to another object.
 */
public class HorizontalTeleporter: MonoBehaviour {
    [SerializeField] Transform teleportTarget;
    
    private void OnTriggerEnter2D(Collider2D other) {
        other.transform.position = new Vector3(teleportTarget.position.x, other.transform.position.y, other.transform.position.z);
    }
}
