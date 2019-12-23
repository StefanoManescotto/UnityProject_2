using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Joystick joystick;

    [SerializeField]
    private CharacterController characterController;

    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    private float speed = 10f; //velocità di movimento

    void Update()
    {
        horizontalMove = joystick.Horizontal * speed; //movimento del joystick asse orizzontale
        verticalMove = joystick.Vertical * speed; //movimento del joystick asse verticale
    }

    void FixedUpdate()
    {
        characterController.Move(new Vector3(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime, 0)); //movimento giocatore
    }

}
