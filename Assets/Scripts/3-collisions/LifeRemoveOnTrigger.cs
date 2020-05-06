using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component removes a single hit-point from the "HitPointCounter" component,
 * whenever its object triggers a 2D collider with the given tag.
 */
public class LifeRemoveOnTrigger: DestroyOnTrigger2D {

    private LifeCounter lifeCounter;

    private void Start() {
        lifeCounter = GetComponent<LifeCounter>();
        if (!lifeCounter)
            throw new MissingComponentException("Must have a LifeCounter component!");
    }

    protected override void DestroyCurrentObject() {
        lifeCounter.Hit();
    }
}
