using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public static int CoinsCollected = 0;
    public static int CoinsToCollected = 20;

    public GameObject[] firework;

    void Awake()
    {
        CoinsToCollected = GameObject.FindGameObjectsWithTag("Coins").Length;
        print("Coin to collected " + CoinsToCollected);
    }

    //Update is called once per frame
    void Update()
    {
        //Check coins collect
        if (CoinsCollected >= CoinsToCollected)
        {
            foreach (GameObject o in firework)
            {
                if (!o.activeSelf)
                {
                    o.SetActive(true);
                }
            }
        }
    }

}
