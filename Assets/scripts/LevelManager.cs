using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pause;
    public GameObject over;
    public GameObject vic;
    void Start()
    {
        pause.SetActive(false);
        over.SetActive(false);
        vic.SetActive(false);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("current_level", SceneManager.GetActiveScene().buildIndex);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
