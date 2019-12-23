using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 75f; //velocità proiettile

    private int tempo = 300;
    private int countDown = 0;

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        countDown++;
        if(countDown >= tempo) //tempo scaduto, distrugge il proiettile
        {
            Destroy(gameObject);
        }
    }

}