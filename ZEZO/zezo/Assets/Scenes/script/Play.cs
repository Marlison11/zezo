using UnityEngine;
using ForceMode2D = UnityEngine.ForceMode2D;
using Mathf = UnityEngine.Mathf;
using MonoBehaviour = UnityEngine.MonoBehaviour;
using Vector2 = UnityEngine.Vector2;

public class Play : MonoBehaviour
{
    private int numero;
    public float velocidade = 40;

    void Start()
    {
        numero = 0;
        
    }

    void Update()
    {
//Debug.log(numero);

//numero = numero +1;

        if (Input.GetKey(KeyCode.A))
        { gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {gameObject.transform.position +=new Vector3(+velocidade *Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        { gameObject.transform.position +=new Vector3(0, velocidade * Time.deltaTime, 0);
        }

    }

    
}
