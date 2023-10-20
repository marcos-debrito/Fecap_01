using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Input.GetAxisRaw("Vertical2"));
    }

    // Update is called once per frame
    void Update()
    {  
        // Input pega os comandos do teclado
        if ((Input.GetAxisRaw("Vertical2") > 0) && (transform.position.y < 4))
        {
            transform.Translate(0, 0.1f, 0);
            Debug.Log("Entrou");
        }else if((Input.GetAxisRaw("Vertical2") < 0) && (transform.position.y > -4)){
            transform.Translate(0, -0.1f, 0);
        }
    }
}
