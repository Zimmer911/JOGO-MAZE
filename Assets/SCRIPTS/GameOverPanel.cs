using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{ 
public GameObject gameOverPanel;

        void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")== null)
            {
            gameOverPanel.SetActive(true);
            
        }
    }

public void Restart()
{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
    public void SairJogo()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }

}