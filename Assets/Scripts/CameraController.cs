using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject sphere;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - sphere.transform.position;
    }

    void LateUpdate() // 在所有Update方法调用之后调用
    {
        transform.position = sphere.transform.position + offset;
    }
}