using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raio : MonoBehaviour
{
    void Update()
    {
        RaycastHit pontoDeColisao;
        if (Physics.Raycast(transform.position, transform.forward,out pontoDeColisao, 5))
        {
            Debug.Log("ESTÁ COLIDINDO");
            Debug.DrawLine(transform.position, pontoDeColisao.point);
        }
        else {

            Debug.Log("NÃO ESTÁ COLIDINDO");
        }
    }
}
