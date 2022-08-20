using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    int currentlevel;
    public GameObject mm, lm;
    public GameObject[] levelbutton;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetInt("lvl", 0);
        currentlevel = PlayerPrefs.GetInt("lvl");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void lvl(int level)
    {
        if (currentlevel + 1 >= level)
        {
            SceneManager.LoadScene(level);
        }
    }

    public void openlevels()
    {
        mm.SetActive(false);
        lm.SetActive(true);
        if (currentlevel >=1)
        {
            levelbutton[1].GetComponent<Image>().color = Color.green;
        }
        if (currentlevel >=2)
        {
            levelbutton[2].GetComponent<Image>().color = Color.green;
        }
        if (currentlevel >= 3)
        {
            levelbutton[3].GetComponent<Image>().color = Color.green;
        }
        if (currentlevel >= 4)
        {
            levelbutton[4].GetComponent<Image>().color = Color.green;
        }
    }

    public void closelevel()
    {
        lm.SetActive(false);
        mm.SetActive(true);
    }
}
