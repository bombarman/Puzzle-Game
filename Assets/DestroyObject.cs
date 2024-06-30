using System.Collections;
using TMPro;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public TextMeshProUGUI textFeedback;
    public bool hiddenLockActivated = false;
    public Transform player;
    public float interactionDistance = 2f; 

    void OnMouseDown()
    {
        if (Vector3.Distance(player.position, transform.position) <= interactionDistance)
        {
            StartCoroutine(ChangeText());
        }
        else
        {
            Debug.Log("Player is too far away to interact.");
        }
    }

    IEnumerator ChangeText()
    {
        if (textFeedback != null)
        {
            textFeedback.text = "A Hidden Lock!";
            yield return new WaitForSeconds(1f);
            textFeedback.text = "";
        }
        else
        {
            Debug.LogError("Text Feedback TextMeshProUGUI component is not assigned.");
        }

        hiddenLockActivated = true;
        gameObject.SetActive(false);
    }
}