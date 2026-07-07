using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}