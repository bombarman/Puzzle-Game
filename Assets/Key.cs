using System.Collections;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{
    public TextMeshProUGUI textFeedback;
    public TextMeshProUGUI textInventory;
    public FindObject3 lockObject;
    public DestroyObject destroyObject;
    public bool keyObtained = false;
    public Transform player; 
    public float interactionDistance = 2f; 

    void OnMouseDown()
    {
        if (Vector3.Distance(player.position, transform.position) <= interactionDistance)
        {
            if (destroyObject != null && destroyObject.hiddenLockActivated)
            {
                if (textFeedback != null)
                {
                    textFeedback.text = "Key obtained!";
                    Invoke("ClearText", 1f);
                }
                if (textInventory != null)
                {
                    textInventory.text = "Key obtained";
                }
                keyObtained = true;
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("DestroyObject not activated or null");
            }
        }
        else
        {
            Debug.Log("Player is too far away to interact.");
        }
    }

    void ClearText()
    {
        textFeedback.text = "";
    }
}