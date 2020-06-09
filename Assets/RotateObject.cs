using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 90f;

    public Vector3 rotateAxis = Vector3.zero;

    private Transform targetTransform = null;

    public bool isLocalSpace;

    void Awake()
    {
        if (!targetTransform)
        {
            targetTransform = GetComponent<Transform>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalSpace)
        {
            targetTransform.Rotate(new Vector3(
                rotateAxis.x * rotateSpeed * Time.deltaTime,
                rotateAxis.y * rotateSpeed * Time.deltaTime,
                rotateAxis.z * rotateSpeed * Time.deltaTime),
                Space.World);

        }
        else
        {
            targetTransform.Rotate(new Vector3(
                        rotateAxis.x * rotateSpeed * Time.deltaTime,
                        rotateAxis.y * rotateSpeed * Time.deltaTime,
                        rotateAxis.z * rotateSpeed * Time.deltaTime),
                        Space.World);
        }


    }
}
