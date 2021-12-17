using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject canva;
    public playerController player_controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        canva.SetActive(true);
        Time.timeScale = 0f;
        player_controller.walk.mute = true;

    }

    public void ResumeGame()
    {
        canva.SetActive(false);
        Time.timeScale = 1f;
        player_controller.walk.mute = false;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
