using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    //public Image healthBar;
    public static int max_health = 3;
    public static int cur_health = 0;
    public GameObject health;

    // Start is called before the first frame update
    void Start()
    {
        cur_health = max_health;
    }

    // Update is called once per frame
    void Update()
    {
        if (cur_health <= 0)
        {
            cur_health = 0;
            SceneManager.LoadScene("GameOver");

        }
        health.GetComponent<Text>().text = "Health: " + cur_health;
    }
}


