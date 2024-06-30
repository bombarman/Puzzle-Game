using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class WrongObject : MonoBehaviour
{
    public TextMeshProUGUI textFeedback;

    void OnMouseDown()
    {
        if (textFeedback != null)
        {
            StartCoroutine(ChangeTextFeedback());
        }
        else
        {
            Debug.LogError("Text Feedback TextMeshProUGUI component is not assigned.");
        }
    }

    IEnumerator ChangeTextFeedback()
    {
        // Update the text to "Wrong Object"
        textFeedback.text = "Wrong Object";
        yield return new WaitForSeconds(1f); // Wait for 1 second
        // Change the text to another message
        textFeedback.text = "";
    }
}