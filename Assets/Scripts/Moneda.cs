using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SalirMoneda();
    }

    public void SalirMoneda()
    {
     
        
            transform.Rotate(0,0,5f);
            //transform.position+=transform.position + new Vector3(0,10,0);
            
        
    }


}
