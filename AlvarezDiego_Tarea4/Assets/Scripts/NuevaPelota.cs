using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NuevaPelota : MonoBehaviour
{
    public GameObject prefab;
    private bool isPaused = false;
    public GameObject pauseMenu;
    private GameObject esfera;
    
    // Start is called before the first frame update


    void Start()
    {
        Time.timeScale = 1.0f;
        if (prefab)
            esfera = Instantiate(prefab, transform.position, transform.rotation);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !esfera)
        {
            nuevo();
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = true;
            TogglePause();
            
           
        }
        //Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
    



    }
    public GameObject nuevo()
    {
        esfera = Instantiate(prefab, transform.position, transform.rotation);
        return esfera;
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
