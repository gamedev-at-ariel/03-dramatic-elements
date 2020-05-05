using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {
    [SerializeField] int firstLevelIndex = 1;
    [SerializeField] int gameOverIndex = 2;

    public void Play() {
        SceneManager.LoadScene(firstLevelIndex);
    }

    public void GameOver() {
        SceneManager.LoadScene(gameOverIndex);
    }

    public void Quit() {
        Application.Quit();
    }
}
