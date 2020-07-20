using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject gameOverScreen;
    
    public void EndGame ()
	{
        if (gameHasEnded == false)
		{
            gameHasEnded = true;
            Invoke("GameOverScreen", restartDelay);
		}
	}

    void GameOverScreen ()
    {
        gameOverScreen.SetActive(true);
    }

    public void Restart ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
