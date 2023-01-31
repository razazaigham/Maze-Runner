using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public AudioClip DoorOpen;

    public AudioSource audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameManager.GM.KeyCollected)
        {
            audio.PlayOneShot(DoorOpen);
            Invoke("LoadNextLevel", 0.5f);
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
