using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindObject3 : MonoBehaviour
{
    public TextMeshProUGUI objectiveText;
    public Key key;
    public Transform player; // Reference to the player's transform
    public float interactionDistance = 2f; // Distance threshold for interaction

    void OnMouseDown()
    {
        if (Vector3.Distance(player.position, transform.position) <= interactionDistance)
        {
            if (key != null && key.keyObtained)
            {
                if (objectiveText != null)
                {
                    objectiveText.text = "You found it!";
                }
                Destroy(gameObject);
            }
            else
            {
                if (objectiveText != null)
                {
                    objectiveText.text = "It's locked";
                    StartCoroutine(ChangeText());
                }
            }
        }
        else
        {
            Debug.Log("Player is too far away to interact.");
        }
    }

    IEnumerator ChangeText()
    {
        yield return new WaitForSeconds(1f);
        objectiveText.text = "";
    }
}
