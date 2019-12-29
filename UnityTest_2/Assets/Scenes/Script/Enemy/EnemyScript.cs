using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    [SerializeField]
    private float speed = 5f;

    private GameObject giocatore;

    private int vita = 100;

    void Start()
    {
        giocatore = GameObject.FindGameObjectWithTag("Player"); //trova giocatore
    }

    void Update()
    {
        if (giocatore != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, giocatore.transform.position, speed * Time.deltaTime); //muove il nemico verso il giocatore
        }
    }

    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Proiettili") //collisione con proiettili
        {
            Destroy(Other.gameObject); //distrugge proiettile
            vita -= 50; //diminuisce vita
            if(vita <= 0)
            {
                Destroy(gameObject); //distrugge nemico
            }
        }
    }

}
