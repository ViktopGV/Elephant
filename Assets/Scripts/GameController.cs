using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void Exit() => Application.Quit();

    public void LoadLevelById(int id) => SceneManager.LoadScene(id); 
}
