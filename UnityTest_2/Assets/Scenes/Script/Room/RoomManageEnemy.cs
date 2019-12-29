using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManageEnemy : MonoBehaviour
{

    [SerializeField]
    private GameObject[] gate;

    void Start()
    {
        GateManager(false); //disabilito i cancelli
        EnableDisableScript(false); //disabilito script spawn nemici
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length > 0) //sono ancora presenti dei nemici
        {
            GateManager(true); //abilito i cancelli
        }
        else //non ci sono nemici
        {
            GateManager(false); //disabilito i cancelli
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") //il giocatore entra in una stanza
        {
            EnableDisableScript(true);
        }
    }

    private void EnableDisableScript(bool action)
    {
        SpawnNemici[] scriptNemici = GetComponentsInChildren<SpawnNemici>();

        for (int i = 0; i < scriptNemici.Length; i++) //ciclo per tutti gli spawn nemici
        {
            scriptNemici[i].enabled = action; //disabilita o abilita script per lo spawn dei nemici
        }

    }

    private void GateManager(bool action)
    {
        gate[0].SetActive(action); //abilita o disabilita i cancelli
        gate[1].SetActive(action);
    }

}
