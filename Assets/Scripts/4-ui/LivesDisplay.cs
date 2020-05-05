using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour {
    void Start() {
        SetLives(transform.childCount);
    }

    public void SetLives(int newLives) {
        for (int i=0; i<newLives && i < transform.childCount; ++i) {
            transform.GetChild(i).GetComponent<Image>().enabled = true;
        }
        for (int i = newLives; i < transform.childCount; ++i) {
            transform.GetChild(i).GetComponent<Image>().enabled = false;
        }
    }

}
