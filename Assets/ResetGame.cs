using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP.cur_health = PlayerHP.max_health;
        PlayerUnit.CoinsCollected = 0;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");
        }


    }


}
