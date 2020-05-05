using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component keeps a "life count" of its object.
 * It destroys one life whenever it triggers a 2D collider with the given tag.
 * When the life count reaches zero, it destroys the object.
 */
public class DestroyOnTriggerOneLife: DestroyOnTrigger2D {
    [Tooltip("The current life-count")]
    [SerializeField] int lifeCount = 3;

    [Tooltip("The UI display of the life-count")]
    [SerializeField] LivesDisplay livesDisplay;

    private void Start() {
        if (livesDisplay)
            livesDisplay.SetLives(lifeCount);
    }

    protected override void DestroyCurrentObject() {
        lifeCount -= 1;
        if (livesDisplay)
            livesDisplay.SetLives(lifeCount);
        if (lifeCount == 0)
            base.DestroyCurrentObject();
    }
}
