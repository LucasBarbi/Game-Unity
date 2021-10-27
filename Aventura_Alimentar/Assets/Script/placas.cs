using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class placas : MonoBehaviour
{
    public GameObject placa;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Placa") == true)
        {
            placa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;

        }
    }
    
    public void ResumeGame()
    {
        placa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;


        // Start is called before the first frame update
        void Start()
        {
          
            placa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
