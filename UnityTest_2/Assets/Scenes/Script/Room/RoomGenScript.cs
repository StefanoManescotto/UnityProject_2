using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenScript : MonoBehaviour
{

    [SerializeField]
    private GameObject[] stanze;

    [SerializeField]
    private int numeroStanze = 5;

    private List<GameObject> stanzeCreate;

    void Start()
    {
        for(int i=0; i<numeroStanze; i++)
        {
            if(i == 0)
            {
                stanzeCreate.Add(Instantiate(stanze[0], Vector3.zero, Quaternion.identity));
            }else if (i < numeroStanze)
            {
                //stanze tb
            }
            else
            {
                //stanze b
            }
        }
    }

    void Update()
    {
        
    }

    void posizioneStanzaSuccessiva()
    {
        //TODO: aggiungere Gameobject spawner alle stanze
        //TODO: stanzaCreate --> trova ultima stanza aggiunta, fare il getComponent allo spawner delle stanze e spawnare prossima stanza in quella posizione
    }

}
