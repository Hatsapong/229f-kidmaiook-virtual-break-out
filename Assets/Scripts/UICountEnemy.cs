using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EnemyCounterUI : MonoBehaviour
{
    public TextMeshProUGUI enemyCountText; // Assign in inspector


    void Update()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemyCountText.text = "" + enemyCount;
    }
}
