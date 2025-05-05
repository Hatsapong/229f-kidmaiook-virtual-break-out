using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ExitZone : MonoBehaviour
{
    public string nextSceneName;             // Name of the scene to load
    public TextMeshProUGUI messageText;                 // Optional: Assign in inspector to show message to player
    private bool playerInside = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            CheckEnemiesRemaining();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            if (messageText != null)
                messageText.text = "";
        }
    }

    void CheckEnemiesRemaining()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            // All enemies killed, proceed to next scene
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            // Enemies remain, show message
            if (messageText != null)
            {
                messageText.text = "Defeat all enemies to proceed!";
            }
            else
            {
                Debug.Log("Defeat all enemies to proceed!");
            }
        }
    }
}
