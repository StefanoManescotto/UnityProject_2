using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField]
    private Joystick joystick;

    [SerializeField]
    private GameObject proiettile;

    private CharacterController test;

    // Update is called once per frame
    void Update()
    {
        
        if(Mathf.Abs(joystick.Horizontal) > 0.2f || Mathf.Abs(joystick.Vertical) > 0.2f)
        {
           /* float horizontal = joystick.Horizontal * Time.deltaTime;
            float vertical = joystick.Vertical * Time.deltaTime;
            float rotZ = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
            transform.rotation  test = Quaternion.Euler(0f, 0f, rotZ);
            Instantiate(proiettile, Transform.Quaternion.Euler(0f, 0f, rotZ)));*/
        }
    }
}
