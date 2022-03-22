using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    public GameObject[] listaCamaras;
    int numeroCamaras=3;
    // Use this for initialization
    void Start () {

        for(int i=0; i<numeroCamaras; i++)
        {
            listaCamaras [i].gameObject.SetActive (false);
        }
        listaCamaras [0].gameObject.SetActive (true);
		
    }
	
    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.Alpha1)) {
            apagarCamaras ();
            listaCamaras [0].gameObject.SetActive (true);
            Debug.Log ("Tecla 1 pulsada");
        }
        if (Input.GetKey (KeyCode.Alpha2)) {
            apagarCamaras ();
            listaCamaras [1].gameObject.SetActive (true);
            Debug.Log ("Tecla 2 pulsada");
        }
        if (Input.GetKey (KeyCode.Alpha3)) {
            apagarCamaras ();
            listaCamaras [2].gameObject.SetActive (true);
            Debug.Log ("Tecla 3 pulsada");
        }
		
    }

    void apagarCamaras()
    {
        for(int i=0; i<numeroCamaras; i++)
        {
            listaCamaras [i].gameObject.SetActive (false);
        }

    }
}
