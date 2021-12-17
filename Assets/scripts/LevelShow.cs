using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelShow : MonoBehaviour
{

    public Text level_label;

    // Start is called before the first frame update
    void Start()
    {
        int current_level_number = SceneManager.GetActiveScene().buildIndex;
        current_level(current_level_number);
    }
        

    public void current_level(int level_number)
    {

        if (level_number > 1 && level_number < 10)
        {
            level_label.text = "Level : " + "0" + level_number;
        }
        else if (level_number >= 10)
        {
            level_label.text = "Level : " + level_number;
        }

        else
        {
            level_label.text = "Level : " + "01";
        }
    }
}
