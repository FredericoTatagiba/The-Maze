using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    public CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("LookAround");

        Vector3 moveCal = transform.right * x + transform.forward * z;

        controller.Move(moveCal * 70 * Time.deltaTime);

        GetComponent<Transform>().Rotate(Vector3.up * rotation * 50);
    }
}
