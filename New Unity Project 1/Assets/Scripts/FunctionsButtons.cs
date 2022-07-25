using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsButtons : MonoBehaviour {


    public void evento(string texto)
    {
        Debug.Log(texto);
    }

    public void apagarLuz(GameObject luz)
    {
        luz.SetActive(false);
        //luz.SetActive(enabled = true);
    }
}
