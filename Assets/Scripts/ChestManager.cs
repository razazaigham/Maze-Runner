using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public bool opened = false;
    public GameObject interactUI;

    public GameObject[] diamonds;
 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !opened)
        {
            interactUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactUI.SetActive(false);
        }
    }

    public void ClickButton()
    {
        GetComponent<Animator>().SetTrigger("Open");
        opened= true;
        interactUI.SetActive(false);
    }

    public void InstantiateDiamonds()
    {
        for (int i = 0; i < diamonds.Length; i++)
        {
            diamonds[i].SetActive(true);
        }
    }
}
