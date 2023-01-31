using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{

    public AudioClip CollectedAudio;

    public AudioSource audio;

    public bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !collected) 
        {
            collected = true;

            GameManager.GM.KeyCollected = true;

            audio.PlayOneShot(CollectedAudio);

            this.transform.GetChild(0).gameObject.SetActive(false);

            Destroy(this.gameObject,1);
        }
    }

}
