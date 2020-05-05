using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component loads a given scene whenever the player hits space.
 */
public class KeyboardSceneLoader: MonoBehaviour {
    [Tooltip("Index of scene to load when player hits space")] [SerializeField] int sceneToLoad = 1;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
