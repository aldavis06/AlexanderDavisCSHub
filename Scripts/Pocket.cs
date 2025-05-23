using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pocket : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private int count;
    void Start()
    {
        count = 0;
        SetCountText();


        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        if (count >= 15)
        {
            winTextObject.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);



        }
    }
}