using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public bool opened = false;
    

    public GameObject[] diamonds;

    public AudioClip OpenChestSound;

    public AudioSource audio;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !opened)
        {
            GameManager.GM.interactUI.SetActive(true);
            other.GetComponent<PlayerManager>().CurrentChest = this;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            GameManager.GM.interactUI.SetActive(false);
            other.GetComponent<PlayerManager>().CurrentChest = null;
        }
    }

    public void ClickButton()
    {
        GetComponent<Animator>().SetTrigger("Open");
        audio.PlayOneShot(OpenChestSound);
        opened = true;
        GameManager.GM.interactUI.SetActive(false);

    }

    public void InstantiateDiamonds()
    {
        for (int i = 0; i < diamonds.Length; i++)
        {
            diamonds[i].SetActive(true);
        }
    }
}
