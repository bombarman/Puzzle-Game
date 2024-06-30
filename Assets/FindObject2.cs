using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FindObject2 : MonoBehaviour
{
    public TextMeshProUGUI objectiveText;
    public Transform player; // Reference to the player's transform
    public float interactionDistance = 2f; // Distance threshold for interaction

    void OnMouseDown()
    {
        if (Vector3.Distance(player.position, transform.position) <= interactionDistance)
        {
            if (objectiveText != null)
            {
                objectiveText.text = "You Found It!";
            }
            else
            {
                Debug.LogError("Objective TextMeshProUGUI component is not assigned.");
            }
            Destroy(gameObject);
            SceneManager.LoadScene("Level 3");
        }
        else
        {
            Debug.Log("Player is too far away to interact.");
        }
    }
}