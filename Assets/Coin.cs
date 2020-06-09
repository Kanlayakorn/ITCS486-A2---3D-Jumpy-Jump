using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool destroySelfOnHit;
    public bool isCollectedByPlayerOnly;

    void OnTriggerEnter(Collider collider)
    {
        if (isCollectedByPlayerOnly)
        {
            if (!collider.CompareTag("Player"))
            {
                return;
            }

        }

        ++PlayerUnit.CoinsCollected;
        if (destroySelfOnHit)
        {
            Destroy(gameObject);
        }

    }
}
