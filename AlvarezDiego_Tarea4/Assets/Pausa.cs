using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pausa : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isPaused = false;
    public GameObject pauseMenu;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Continuar();
            }
            else
            {
                TogglePause();
            }
            //isPaused = true;
            //TogglePause();


        }
    }
    public void TogglePause()
    {
       
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }
    public void Continuar()
    {

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");

    }
    public void ResartScene()
    {
        SceneManager.LoadScene("Game");
    }
}
