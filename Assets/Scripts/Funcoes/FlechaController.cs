using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechaController : MonoBehaviour
{
    //Velocidade da flecha
    [SerializeField] private float Velocidade;
    public Pontos pontuacao;
    

    void Update(){
        //Move a flecha na dire��o � sua direita
        //O Time.deltaTime faz a velocidade adaptar � taxa de fps do jogo,
        //assim mantendo a velocidade constante em computadores de desempenho diferentes
        transform.transform.position += transform.right * (Velocidade+20) * Time.deltaTime;
            

    }

    //Ao colidir
    private void OnCollisionEnter2D(Collision2D collision){
          OnBecameInvisible();
        //verifica se o objeto possui o atributo "vida"
        if(collision.gameObject.TryGetComponent<Vida>(out var Vida)){

            //cause dano e desaparece
            Vida.setTomouDano(true);
            Vida.Dano(20);
          

        }
        
        
    }

    //Ao sair do campo de vis�o de todas as c�meras
    private void OnBecameInvisible(){
        //Destr�i a flecha
        Destroy(this.gameObject);
    }
}
