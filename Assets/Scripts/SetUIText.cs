using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SetUIText : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textField;
    [SerializeField]
    private string fixedText;

    public void OnSliderValueChanged(float numericValue)
    {
        textField.text = $"{fixedText}: {numericValue}";
    }
}
