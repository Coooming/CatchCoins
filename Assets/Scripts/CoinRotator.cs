using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    public Vector3 rotationVelocity;

    void Update()
    {
        transform.Rotate(rotationVelocity);
    }
}