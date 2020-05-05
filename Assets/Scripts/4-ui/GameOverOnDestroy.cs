using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component loads the "game over" scene
 * whenever its object is destroyed.
 */
public class GameOverOnDestroy : MonoBehaviour {
    [SerializeField] int gameOverSceneIndex;

    private void OnDestroy() {
        SceneManager.LoadScene(gameOverSceneIndex);
    }
}
