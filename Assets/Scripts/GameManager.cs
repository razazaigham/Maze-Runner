using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public bool KeyCollected = false;
    public Toggle KeyToggle;

    public Text DiamondsText;
    public int DiamondsCollected = 0;
    public GameObject interactUI;

    public PlayerManager player;

    private void Awake() => GM = this;


    private void Update()
    {
        if (KeyCollected)
        {
            KeyToggle.isOn = true;
        }

        DiamondsText.text = ": " + DiamondsCollected;
    }

    public void OpenChess()
    {
        player.CurrentChest.ClickButton();
    }
}
