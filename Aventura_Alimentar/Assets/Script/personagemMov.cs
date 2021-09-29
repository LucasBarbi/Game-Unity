using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagemMov : MonoBehaviour
{
    public Rigidbody2D corpoPersonagem;
    private float direcao;
    public float velocidade;
    public float forcaPulo;
    private bool estaNoChao;
    public Transform posicaoDoPe;
    public LayerMask chao;

    private bool olhandoDireita = true;
    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        estaNoChao = Physics2D.OverlapCircle(posicaoDoPe.position, 0.3f, chao);


        direcao = Input.GetAxisRaw("Horizontal");
        corpoPersonagem.velocity = new Vector2(direcao * velocidade, corpoPersonagem.velocity.y);
        animator.SetFloat("velocidade", Mathf.Abs(direcao));

        if ((direcao < 0 && olhandoDireita) || (direcao > 0 && !olhandoDireita))
        {
            olhandoDireita = !olhandoDireita;
            transform.Rotate(0f, 180f, 0f);
        }

        if (estaNoChao && Input.GetKeyDown(KeyCode.Space))
        {
            corpoPersonagem.velocity = Vector2.up * forcaPulo;
        }
    }
}