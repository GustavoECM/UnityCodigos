using UnityEngine;
using System.Collections;

public class Ponto : MonoBehaviour {

    public Transform atualTransforme;
    public Transform[] coaminhos;
    public NavMeshAgent navegador;

    int i = 0;
	void Start () {

        navegador.destination = coaminhos[i].position;


    }
	
	// Update is called once per frame
	void Update () {

        float dist = Vector3.Distance(coaminhos[i].position, transform.position);
        atualTransforme = coaminhos[i];

        if (dist < 2)
        {
            if (i < coaminhos.Length - 1) //comparação usada para ver se o valor de i ja e maximo.
            {
                i++;
                navegador.destination = coaminhos[i].position;

            
            }else
            {
                i--;
                navegador.destination = coaminhos[i].position;
            }
        }

    }



}
