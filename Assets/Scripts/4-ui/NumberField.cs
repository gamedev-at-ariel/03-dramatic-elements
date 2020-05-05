using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
public class NumberField : MonoBehaviour {
    private TMP_Text textField;
    private int number;

    void Start()    {
        textField = GetComponent<TextMeshPro>();
        if (!textField)
            textField = GetComponent<TextMeshProUGUI>();
        if (!textField)
            throw new MissingComponentException("Object must contain a TextMeshPro or a TextMeshProUGUI field!");
    }

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        this.textField.text = newNumber.ToString();
    }
}
