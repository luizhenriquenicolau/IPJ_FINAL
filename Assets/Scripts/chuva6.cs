using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuva6 : MonoBehaviour
{
    public float tempo2;
    public float queda;
    private TargetJoint2D target2;

    Vector3 startPosition;
    Quaternion startRotation;
    // Start is called before the first frame update
    void Start()
    {
        target2 = GetComponent<TargetJoint2D>();
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        tempo2 += Time.deltaTime;

        if (tempo2 >= 9.0f)
        {
            target2.enabled = false;

        }
        if (tempo2 >= 18.0f)
        {
            target2.enabled = true;
            tempo2 = 0.0f;
            transform.position = startPosition;
            transform.rotation = startRotation;

        }

    }

}
