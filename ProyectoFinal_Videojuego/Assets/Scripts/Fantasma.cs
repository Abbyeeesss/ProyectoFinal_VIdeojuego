using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Trigger detectado con: " + collision.name);

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Entró en la casa buscando respuestas...  \r\npero las sombras ya sabían su nombre.  \r\nLa Presencia lo esperaba, paciente.  \r\nY cuando extendió su mano, él dejó de existir.\r\n");
            Destroy(gameObject);
        }
    }
}
