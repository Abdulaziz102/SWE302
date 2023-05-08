using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    public int num;
    private TextMeshProUGUI txt;
    private Player player;
    private void OnTriggerEnter(Collider other)
    {
        txt = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
    }

    private void OnTriggerStay(Collider other)
    {
        txt.text = "Press (E) to Click " + num;
        player.interactingWithNum = true;
        player.numberToInteract = num;
    }

    private void OnTriggerExit(Collider other)
    {
        txt.text = "";
        player.interactingWithNum = false;
        player.numberToInteract = 0;
    }
}
