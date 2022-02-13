using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereController : MonoBehaviour
{
    public float speed = 10;
    public Text countText;
    public Text winText;

    private Rigidbody theRigidbody;
    private int count = 0;

    void Start()
    {
        theRigidbody = GetComponent<Rigidbody>();
        countText.text = "Score:  " + count;
        winText.text = "";
    }

    void FixedUpdate() // 在固定的时间间隔执行，不受游戏帧率的影响
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hInput, 0, vInput);
        theRigidbody.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider Other)
    {
        Other.gameObject.SetActive(false);
        count++;
        countText.text = "Score:  " + count;
        if (count == 8) winText.text = "YOU WIN!";
    }
}