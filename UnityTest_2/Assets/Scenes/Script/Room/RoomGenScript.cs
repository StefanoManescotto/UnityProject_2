using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenScript : MonoBehaviour
{

    [SerializeField]
    private GameObject[] stanze;

    [SerializeField]
    private int numeroStanze = 5;

    private List<GameObject> stanzeCreate = new List<GameObject>();

    void Start()
    {

        GameObject stanza;

        for(int i=0; i<numeroStanze; i++) //ciclo per il numero delle stanze
        {
            if(i == 0)
            {
                stanzeCreate.Add(Instantiate(stanze[2], Vector3.zero, Quaternion.identity)); //creo prima stanza ('t')
            }else if (i < numeroStanze - 1)
            {
                stanzeCreate.Add(Instantiate(stanze[1], posizioneStanzaSuccessiva(), Quaternion.identity));  //creo stanze in metà ('bt')
            }
            else
            {
                stanzeCreate.Add(Instantiate(stanze[0], posizioneStanzaSuccessiva(), Quaternion.identity)); //creo ultima stanza ('b')
            }
        }
    }

    void Update()
    {
        
    }

    Vector3 posizioneStanzaSuccessiva()
    {
        Transform posizione = stanzeCreate[stanzeCreate.Count - 1].transform.Find("Spawner"); //posizione prossima stanza da creare
        return posizione.position;
    }
    
}
