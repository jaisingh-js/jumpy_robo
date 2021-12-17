using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class level_complete : MonoBehaviour
{
    public GameObject vic;
    public int next_level_num;
    public playerController player_c;
    public AudioSource victory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.tag == "Player")
        {
            vic.SetActive(true);
            Time.timeScale = 0f;
            player_c.walk.mute = true;
            player_c.jump_sound.mute = true;
            victory.Play();
            PlayerPrefs.SetInt("level", next_level_num);
        }
    }
}
