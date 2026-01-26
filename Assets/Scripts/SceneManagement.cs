using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private void LoadPath()
    {
        SceneManager.LoadScene(1);
    }

    private void LoadDocks()
    {
        SceneManager.LoadScene(2);
    }

    private void LoadMarket()
    {
        SceneManager.LoadScene(3);
    }
}
