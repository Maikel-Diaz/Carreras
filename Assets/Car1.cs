using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car1 : MonoBehaviour {

    private float velocidad = -0.1f;
    public KeyCode teclaAsignada = KeyCode.F1;
    public string nombre;
    private int contador = 0;
    public GameObject coche;
    public Text marcador1;
    public Text ganador;
    public bool colision = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(teclaAsignada) && colision == false)
        {
            this.transform.Translate(new Vector3(0, velocidad, 0));
            contador++;
            marcador1.text = "" + contador;
            
        }
    }
    void OnTriggerEnter2D(Collider2D collid)
    {
        Debug.Log("El ganador es: " + nombre);
        ganador.text = "El ganador es " + nombre;
        velocidad = 0;
        colision = true;
    }
    


}
