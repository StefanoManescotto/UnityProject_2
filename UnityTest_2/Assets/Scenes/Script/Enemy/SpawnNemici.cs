using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNemici : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    void Start()
    {
        Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
    }

    void Update()
    {
        //TODO: movimento nemici
    }
}
