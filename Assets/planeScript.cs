using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour
{

    public int resistencia;
    public sphereScript sphere;

    //cuando un objeto colisiones ocn este debe escribirse en la consola la planbra "Contacto"

    public void OnCollisionEnter(Collision collision)
    {
        sphere = collision.gameObject.GetComponent<sphereScript>();
        Debug.Log("Contacto con una esfera que pesa " + sphere.peso);
    }
}
