using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component tracks the number of 'lives' that its object has.
 * It destroys its object when the number of lives goes to 0 or below.
 */
public class LifeCounter : MonoBehaviour {
    [Tooltip("The number of remaining lives")]
    [SerializeField] int lifeCount = 1;

    [Tooltip("The UI display of the lives. Optional")]
    [SerializeField] LifeDisplay lifeDisplay = null;

    private void Start() {
        if (lifeDisplay)
            lifeDisplay.SetLives(lifeCount);
    }

    public void Hit(int damage=1) {
        lifeCount = Mathf.Max(0, lifeCount - damage);
        lifeDisplay.SetLives(lifeCount);
        if (lifeCount <= 0) {
            Destroy(gameObject);
        }
    }
}
