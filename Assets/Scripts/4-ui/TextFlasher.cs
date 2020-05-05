using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFlasher : MonoBehaviour
{
    [Tooltip("Duration of flash, in seconds")] [SerializeField] float duration = 1f;

    private void Start() {
        StartFlashing();
    }

    public void StartFlashing() {
        StartCoroutine(Flash());
    }

    IEnumerator Flash() {
        for (; ; ) {
            GetComponent<Text>().enabled = true;
            yield return new WaitForSeconds(duration);
            GetComponent<Text>().enabled = false;
            yield return new WaitForSeconds(duration);
        }
    }
}
