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
            Debug.Log("EST� COLIDINDO");
            Debug.DrawLine(transform.position, pontoDeColisao.point);
        }
        else {

            Debug.Log("N�O EST� COLIDINDO");
        }
    }
}
