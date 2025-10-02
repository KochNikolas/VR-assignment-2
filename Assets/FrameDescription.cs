using UnityEngine;
using TMPro;

public class FrameDescription : MonoBehaviour
{
    [TextArea]
    public string descriptionText;       // You type this in the Inspector
    public GameObject descriptionUI;     // Drag in the Canvas
    public TMP_Text descriptionTMP;      // Drag in the TMP text

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your Player has the "Player" tag
        {
            descriptionUI.SetActive(true);
            descriptionTMP.text = descriptionText;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            descriptionUI.SetActive(false);
        }
    }
}
