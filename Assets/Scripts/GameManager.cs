using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject PlayerPrefab;

    public GameObject FloorArea;
    public GameObject ChestPrefab;
    public GameObject KeyPrefab;

    public Transform SpawnArea;

    public bool KeyCollected = false;
    public Toggle KeyToggle;

    public Text DiamondsText;
    public int DiamondsCollected = 0;
    public UICanvasControllerInput interactUI;

    public PlayerManager player;

    public GameObject Gate;

    private void Awake() => instance = this;

    private void Start()
    {
        Instantiate(PlayerPrefab,SpawnArea);
        SpawnObjects();
    }

    private void Update()
    {
        if (KeyCollected)
        {
            KeyToggle.isOn = true;
        }

        DiamondsText.text = ": " + DiamondsCollected;
    }

    void SpawnObjects()
    {
        int random=Random.Range(0, FloorArea.transform.childCount);
        GameObject obj = Instantiate(ChestPrefab, FloorArea.transform.GetChild(random));
        obj.transform.localPosition = new Vector3(0, 0.2f, 0);

        random = Random.Range(0, FloorArea.transform.childCount);
        obj = Instantiate(ChestPrefab, FloorArea.transform.GetChild(random));
        obj.transform.localPosition = new Vector3(0, 0.2f, 0);

        random = Random.Range(0, FloorArea.transform.childCount);
        obj = Instantiate(KeyPrefab, FloorArea.transform.GetChild(random));
        obj.transform.localPosition = new Vector3(0, 0.2f, 0);
    }
}
