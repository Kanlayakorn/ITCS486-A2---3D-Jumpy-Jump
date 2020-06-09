using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeOut : MonoBehaviour
{
    private IEnumerator coroutine;
    public float totalTime = 60f;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = RestartTheScene();

        print(" Restart Level: Countdown - " + totalTime);
        StartCoroutine(RestartTheScene());
    }

    private IEnumerator RestartTheScene()
    {
        while (totalTime > 0)       //Countdown game timer
        {
            totalTime--;
            yield return new WaitForSeconds(1.0f);
            // Continue the code at this line
        }
        if (PlayerUnit.CoinsToCollected <= 0)
        {
            print("Setup run-time error: PlayerUnit.CoinsTocollected is <= 0");
        }
        else if (PlayerUnit.CoinsCollected < PlayerUnit.CoinsToCollected)
        {
            print("Player coins = " + PlayerUnit.CoinsCollected + "/" + PlayerUnit.CoinsToCollected);
            print("Player failed to complete the game: Restart the level");

            coroutine = LoadYourAsyncScene();
            StartCoroutine(coroutine);
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
