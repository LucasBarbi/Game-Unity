using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ponto : MonoBehaviour
{

    public Text scoreTxt;
    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("banana")==true)
        {
            score = score + 10;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("maca"))
        {
            score = score + 10;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("abacate") == true)
        {
            score = score + 8;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("brocolis") == true)
        {
            score = score + 8;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("morango") == true)
        {
            score = score + 10;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("coco") == true)
        {
            score = score + 6;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("laranja") == true)
        {
            score = score + 10;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("dunuts") == true)
        {
            score = score - 10;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("bacon") == true)
        {
            score = score - 25;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("doce") == true)
        {
            score = score - 12;
            Destroy(col.gameObject);
        }

        
    }

}
