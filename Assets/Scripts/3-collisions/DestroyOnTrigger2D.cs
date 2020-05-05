using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D: MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    virtual protected void DestroyCurrentObject() {
        Destroy(this.gameObject);  
    }

    virtual protected void DestroyOtherObject(Collider2D other) {
        Destroy(other.gameObject);  // the other object is destroyed even if the component is disabled (shield).
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            if (enabled) {   // this object is destroyed only if the component is enabled (no shield).
                DestroyCurrentObject();
            }
            DestroyOtherObject(other);  // the other object is destroyed even if the component is disabled (shield).
        }
    }
}
