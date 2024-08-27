using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneWithDelay(string sceneName, float delay)
    {
        Invoke(nameof(LoadTargetScene), delay);
    }

    // M�todo que carga la escena
    private void LoadTargetScene()
    {
        SceneManager.LoadScene("Juego");
    }
}
