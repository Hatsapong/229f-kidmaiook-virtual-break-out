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
    
    public void Finish_game()
    {
        SceneManager.LoadScene(3);
    }
    public void Menu_game()
    {
        SceneManager.LoadScene(4);
    }
    
    public void Exit_game()
    {
        Application.Quit();
    }
}
