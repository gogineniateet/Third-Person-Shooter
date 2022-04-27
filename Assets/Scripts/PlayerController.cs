using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
        
    [SerializeField] CharacterController characterController;
    [SerializeField] Animator animator;


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
        characterController.SimpleMove(movement * constants.playerSpeed * Time.deltaTime);
        //AudioController.instance.PlayAudioClip(constants.WalkSound1);
        animator.SetFloat("Speed", movement.magnitude);

        //if (movement.magnitude > 0f)
        //{
        //    Quaternion tempDistance = Quaternion.LookRotation(movement);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, tempDistance, Time.deltaTime * playerRotateSpeed);
        //}

        transform.Rotate(Vector3.up * inputX * constants.playerRotateSpeed * Time.deltaTime);
        if(inputZ !=0)
        {
            characterController.SimpleMove(transform.forward *inputX* Time.deltaTime);
        }
    }
}
