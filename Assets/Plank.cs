using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    float speed = 300f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        //other.gameObject.GetComponent<HealthPlayer>().TakeDamage(damage);
        PlayerHP.cur_health -= 1;

    }
}

