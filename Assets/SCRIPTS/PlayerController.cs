using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float mouseSensitivity = 2.0f;

    private CharacterController characterController;

    private float verticalRotation = 0f;

    void Start()
    {

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Rotação do jogador com o mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(Vector3.up * mouseX);

        // Rotação da câmera com o mouse
        float mouseY = -Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation += mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Movimento do jogador com teclado
        float forward = Input.GetAxis("Vertical");
        float sideways = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(sideways, 0, forward).normalized;

        // Aplica movimento
        characterController.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }
}
