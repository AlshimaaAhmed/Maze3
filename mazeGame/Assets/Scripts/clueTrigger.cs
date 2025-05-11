using UnityEngine;
using TMPro;

public class clueTrigger : MonoBehaviour
{
    public GameObject cluePanel;
    public TextMeshProUGUI clueText;
    public AudioSource clueSound;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(Application.persistentDataPath);

        if (other.CompareTag("Player"))
        {
            cluePanel.SetActive(true);
            string characterName = gameObject.name;
            string clue = ClueManager.Instance.GetClueForCharacter(characterName);
            clueText.text = clue;

            if (clueSound != null)
                clueSound.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cluePanel.SetActive(false);
        }
    }
}
