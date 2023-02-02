using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerManager : MonoBehaviour
{

    public GameObject objectToThrow;
    public Transform ThrowArea;
    public float TotalthrowForce = 5f;
    public float throwUpForce = 5f;

    public GameObject FlashLight;

    Animator anim;
    StarterAssetsInputs _input;

    public ChestManager CurrentChest = null;

    private void Start()
    {
        anim=GetComponent<Animator>();
        _input = GetComponent<StarterAssetsInputs>();
        FillData();
    }

    private void Update()
    {
        Action();
    }

    void FillData()
    {
        GameManager.instance.interactUI.starterInputs = _input;
        GameManager.instance.player = this;
    }

    public void ThrowObject()
    {
        GameObject thrownObject = Instantiate(objectToThrow, ThrowArea.position, Quaternion.identity);
        thrownObject.transform.LookAt(transform);
        Rigidbody rb = thrownObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(transform.forward.x, (throwUpForce/10), transform.forward.z) * TotalthrowForce, ForceMode.Impulse);
        anim.SetBool("Throw", false);
    }

    public void ShowTorch()
    {
        
        FlashLight.transform.parent.gameObject.SetActive(true);
    }

    public void HideTorch()
    {
        FlashLight.transform.parent.gameObject.SetActive(false);
    }

    public void TurnOnTorch()
    {
        FlashLight.transform.GetChild(1).gameObject.SetActive(false);
        FlashLight.transform.GetChild(0).gameObject.SetActive(true);
        print("Turn on");
    }

    public void TurnOffTorch()
    {
        FlashLight.transform.GetChild(0).gameObject.SetActive(false);
        FlashLight.transform.GetChild(1).gameObject.SetActive(true);
        print("Turn off");
    }

    void Action()
    {
        if(_input.Open)
        {
            print("a");
            if (CurrentChest != null) 
            {
                CurrentChest.ClickButton();
            }
            
            _input.Open = false;
        }

        if (_input.Throw)
        {
            anim.SetBool("Throw", true);
            _input.Throw = false;
        }

        if (_input.Torch)
        {
            anim.SetBool("Torch", !anim.GetBool("Torch"));
            _input.Torch = false;
        }
    }
}
