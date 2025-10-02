using UnityEngine;

public class InfoTriggerPNG : MonoBehaviour
{
    public GameObject infoImage; // Quad mit PNG-Material

    private void Start()
    {
        infoImage.SetActive(false); // am Anfang unsichtbar
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoImage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoImage.SetActive(false);
        }
    }
}