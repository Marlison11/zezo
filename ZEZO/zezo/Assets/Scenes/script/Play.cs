using UnityEngine;

public class Play : MonoBehaviour
{
    private int numero;
    public fleat velocidade = 40;
    void Start()
    {
        numero = 0; 
    }

    void Update()
    {
//Debug.log(numero);

//numero = numero +1;

        if (input.GetKey(KeyCode.A))
    }
    gameObject.transform.position += new Vector3(velocidade,0,0);