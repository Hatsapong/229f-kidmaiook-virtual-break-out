using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenScip : MonoBehaviour
{
    public void Game_over()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Gameplay_game()
    {
        SceneManager.LoadScene(2);
    }
    
}
