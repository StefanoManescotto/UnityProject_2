using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    private int vita = 100;

    void Update()
    {
        //TODO: Inseguimento Giocatore
    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.tag == "Proiettili")
        {
            Destroy(Other.gameObject);
            vita -= 50;
            if(vita <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
