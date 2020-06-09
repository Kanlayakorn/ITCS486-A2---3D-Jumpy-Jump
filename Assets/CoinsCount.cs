using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinsCount : MonoBehaviour
{
    public GameObject hudLine_1;

    // Update is called once per frame
    void Update()
    {
        hudLine_1.GetComponent<Text>().text = "Coins Collected " +
                PlayerUnit.CoinsCollected + " / " +
                PlayerUnit.CoinsToCollected;

        if (PlayerUnit.CoinsCollected == 20)
        {
            PlayerUnit.CoinsCollected = 0;
            SceneManager.LoadScene("Winner");
        }
    }



}
