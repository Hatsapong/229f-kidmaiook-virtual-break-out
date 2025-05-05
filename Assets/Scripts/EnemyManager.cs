using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    public int totalEnemies = 10;
    public Text enemyCountText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateEnemyUI();
    }

    public void EnemyKilled()
    {
        totalEnemies--;
        UpdateEnemyUI();

        if (totalEnemies <= 0)
        {
            Debug.Log("All enemies defeated!");
        }
    }

    private void UpdateEnemyUI()
    {
        if (enemyCountText != null)
            enemyCountText.text = "Enemies Left: " + totalEnemies;
    }
}
