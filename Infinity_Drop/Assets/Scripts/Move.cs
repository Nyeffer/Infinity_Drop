﻿using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Move : MonoBehaviour
{  
    public float moveSpeed; // Decimal number that multiples the Direction to Move Faster
    public float rotSpeed; // Decimal number that multiples the Rotation to Rotate Faster
    private int sprintSpeed; // integer to increase moveSpeed exponentially
    private bool isSprinting; // manage Sprinting
    public float Stamina = 10; // Finite resource to be able to move faster
    public GameObject groundCheck; // an Object with GroundCheck script
    private bool isGrounded; // manage the ability to jump

    void Start() {
        sprintSpeed = 3;
        isSprinting = false;
    }

    void Update() {
        isGrounded = groundCheck.GetComponent<GroundCheck>().GetisGround();
    }



    public void MoveForward(Vector3 direction, float moveSpeed) {
        if(isSprinting) {
            gameObject.transform.Translate(direction * (Time.deltaTime * moveSpeed * 2));
        } else {
            gameObject.transform.Translate(direction * (Time.deltaTime * moveSpeed));
        }
    }

    public void MoveBackward(Vector3 direction, float moveSpeed) {
       if(isSprinting) {
            gameObject.transform.Translate(-direction * (Time.deltaTime * moveSpeed * 2));
        } else {
            gameObject.transform.Translate(-direction * (Time.deltaTime * moveSpeed));
        }
    }

    public void MoveRight(Vector3 direction, float moveSpeed) {
        if(isSprinting) {
            gameObject.transform.Translate(direction * (Time.deltaTime * moveSpeed * 2));
        } else {
            gameObject.transform.Translate(direction * (Time.deltaTime * moveSpeed));
        }
    }

    public void MoveLeft(Vector3 direction, float moveSpeed) {
        if(isSprinting) {
            gameObject.transform.Translate(-direction * (Time.deltaTime * moveSpeed * 2));
        } else {
            gameObject.transform.Translate(-direction * (Time.deltaTime * moveSpeed));
        }
    }

    public void RotateLeft(Vector2 direction, float rotSpeed) {
        gameObject.transform.Rotate(0, direction.x * (rotSpeed * Time.deltaTime), 0);
    }

    public void RotateRight(Vector2 direction, float rotSpeed) {
        gameObject.transform.Rotate(0, direction.x * (rotSpeed * Time.deltaTime), 0);
    }

    public void Sprint(bool NowOrNot) {      
            SetisSprinting(NowOrNot);
    }

    public bool GetisSprinting() {
        return isSprinting;
    }


    public void SetisSprinting(bool NowSprint) {
        isSprinting = NowSprint;
    }

    public bool GetisGrounded() {
        return isGrounded;
    }


    
}