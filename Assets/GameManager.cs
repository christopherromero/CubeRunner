using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            // Restart Game
            Invoke("Restart", restartDelay);

        }
    }

    public bool GetGameHasEnded()
    {
        return gameHasEnded;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
