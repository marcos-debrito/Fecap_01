using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Input pega os comandos do teclado
      if((Input.GetAxisRaw("Vertical") > 0) && (transform.position.y < 4)) 
      {
          // transform -> controla a posição, rotação e a escala 
          // vetor (x, y, z) alterando as direções de acordo com a necessidade
          // Unity trabalha sempre com float
          transform.Translate(0, 0.1f, 0);
      } else if ((Input.GetAxisRaw("Vertical") < 0) && (transform.position.y > -4))
      {
          transform.Translate(0, -0.1f, 0);
      }
    }
}
