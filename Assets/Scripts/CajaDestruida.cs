using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaDestruida : MonoBehaviour
{
    public GameObject cajaFragmentos;
    public GameObject sonido;
    public GameObject moneda;
    public GameObject canvasYouWin;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        //throw new NotImplementedException();
        if (collision.gameObject.name == "Piso")
        {
            
            Destroy(this.gameObject);
            Instantiate(sonido);
            Instantiate(moneda, transform.position, Quaternion.identity);
            Instantiate(cajaFragmentos, transform.position, Quaternion.identity);
            moneda.SetActive(true);
            canvasYouWin.SetActive(true);
        }

        
    }

   
}
