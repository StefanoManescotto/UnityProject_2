using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private Joystick joystick; //secondo joystick --> camera + shooting
    [SerializeField]
    private GameObject proiettile;


    [SerializeField]
    private float waitTime = 100f;
    private float timer;

    private CharacterController test;

    void Update()
    {
        if (Mathf.Abs(joystick.Horizontal) > 0.2f || Mathf.Abs(joystick.Vertical) > 0.2f)
        {
            float direzione = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg; //calcola la direzione del secondo joystick
            transform.rotation = Quaternion.Euler(0f, 0f, direzione); //cambia direzione giocatore
            timer++;
            if (timer > waitTime)
            {
                GameObject prefab = Instantiate(proiettile, transform.position, Quaternion.Euler(0f, 0f, direzione)); //crea proiettile
                timer = 0f;
            }
        }
    }
}
