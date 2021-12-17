using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Selecter : MonoBehaviour
{

    public Button l1, l2, l3, l4, l5, l6, l7, l8, l9, l10;
    private int lvl_unlock;
    void Start()
    {
        lvl_unlock = PlayerPrefs.GetInt("level");
        l1.interactable = true;
        l2.interactable = false;
        l3.interactable = false;
        l4.interactable = false;
        l5.interactable = false;
        l6.interactable = false;
        l7.interactable = false;
        l8.interactable = false;
        l9.interactable = false;
        l10.interactable = false;



        switch (lvl_unlock)
        {
            case 1 :
                l1.interactable = true;
                break;

            case 2 :
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 3 :
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 4:
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 5:
                l5.interactable = true;
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 6:
                l6.interactable = true;
                l5.interactable = true;
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 7:
                l7.interactable = true;
                l6.interactable = true;
                l5.interactable = true;
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 8:
                l8.interactable = true;
                l7.interactable = true;
                l6.interactable = true;
                l5.interactable = true;
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 9:
                l9.interactable = true;
                l8.interactable = true;
                l7.interactable = true;
                l6.interactable = true;
                l5.interactable = true;
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            case 10:
                l10.interactable = true;
                l9.interactable = true;
                l8.interactable = true;
                l7.interactable = true;
                l6.interactable = true;
                l5.interactable = true;
                l4.interactable = true;
                l3.interactable = true;
                l2.interactable = true;
                l1.interactable = true;
                break;

            default :
                l1.interactable = true;
                break;

        }
    }

    // Update is called once per frame
    public void Load_level(int level)
    {
        SceneManager.LoadScene(level);
    }
}
