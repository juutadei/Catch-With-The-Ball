using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<GameManager>().moedasNaFase += 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().DescontarMoedas();
            Destroy(this.gameObject);
        }
    }
}
