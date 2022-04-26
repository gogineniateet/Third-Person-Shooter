using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed;
    public float playerRotateSpeed;
    CharacterController characterController;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(inputX, 0f, inputZ);
        characterController.SimpleMove(movement * playerSpeed * Time.deltaTime);

        animator.SetFloat("Speed", movement.magnitude);

        //if (movement.magnitude > 0f)
        //{
        //    Quaternion tempDistance = Quaternion.LookRotation(movement);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, tempDistance, Time.deltaTime * playerRotateSpeed);
        //}

        transform.Rotate(Vector3.up, inputX * playerRotateSpeed * Time.deltaTime);
        if(inputZ !=0)
        {
            characterController.SimpleMove(transform.forward * Time.deltaTime);
        }
    }
}
