using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Placa2 : MonoBehaviour
{
    public GameObject placaa;

    public float cronometro;
    public int tempoLimite = 3;

    private void OnTriggerEnter2D(Collider2D col)
    {    
        Update();
        if (col.CompareTag("Placa2") == true)
        {
            cronometro = 0;
            placaa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }

    public void ResumeGame()
    {
        placaa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


        // Start is called before the first frame update
        void Start()
        {
            placaa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        cronometro += Time.deltaTime;
        if (cronometro > tempoLimite)
        {
            cronometro = 0;
            placaa.SetActive(false);
        }
    }
}
