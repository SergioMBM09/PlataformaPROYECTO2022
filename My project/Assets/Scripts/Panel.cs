using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public Text cuadro_text;
    public string nombre_producto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Debug.Log("PRENDIDO");
        if (gameObject.name=="PanelCompraExito")
        {
            cuadro_text.text = "compraste " + nombre_producto;
        }
        else
        {
            cuadro_text.text = "error, no puedes comprar " + nombre_producto;
        }
    }
    private void OnDisable()
    {
        Debug.Log("APAGADO");
    }
}