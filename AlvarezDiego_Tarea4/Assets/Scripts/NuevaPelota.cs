using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NuevaPelota : MonoBehaviour
{
    
    private bool isPaused = false;
    public GameObject pauseMenu;
    
    
    // Start is called before the first frame update


    void Start()
    {
        Time.timeScale = 1.0f;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = true;
            TogglePause();
            
           
        }
        //Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
    



    }

    public void TogglePause()
    {
        if (pauseMenu)
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0.0f : 1.0f;

        }
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
    public void Scene2()
    {
        SceneManager.LoadScene("MouseEvent");
    }

}
