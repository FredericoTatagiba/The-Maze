using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    public CharacterController controller;

    void Start()
    {
        
    }

    void Update()
    {
        //Variaveis para receber os valores de movimentação do player
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("LookAround");

        //Calculo de movimentação de acordo com o transform e as posições
        Vector3 moveCal = transform.right * x + transform.forward * z;

        //Depois esse calculo é aplicado ao controller de movimento do player
        controller.Move(moveCal * 10 * Time.deltaTime);

        //Em seguida é aplicado a variavel de rotação da camera
        GetComponent<Transform>().Rotate(Vector3.up * rotation * 10);
    }
}
