using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public float velocidadeDoJogador;
    public Rigidbody oRigidbody;

    private float movimentoX;
    private float movimentoZ;

    void Start()
    {
        
    }

    void Update()
    {
        MovimentarBola();
    }

    private void MovimentarBola()
    {
        movimentoX = Input.GetAxis("Horizontal") * velocidadeDoJogador;
        movimentoZ = Input.GetAxis("Vertical") * velocidadeDoJogador;

        oRigidbody.AddForce(movimentoX, 0f, movimentoZ);
    }
}
