using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tienda : MonoBehaviour
{
    // Start is called before the first frame update
    public int Moneda01;
    public GameObject PanelExito;
    public GameObject PanelError;
    public Text txt_dinero;

    private void Awake()
    {
        txt_dinero.text = "Dinero: " + Moneda01;
    }
    public void Comprar(int precio_producto, string nombre_producto)
    {

        if (Moneda01 - precio_producto >= 0)
        {
            Moneda01 -= precio_producto;
            txt_dinero.text = "Dinero: " + Moneda01;
            switch (nombre_producto)
            {
                case "CERVEZA":Debug.Log("CAMBIAR SKINS");
                    break;

                case "VINO":Debug.Log("RECUPERAR VIDAS");
                    break;

                default:Debug.Log("VER PUBLICIDAD");
                    break;
            }
            PanelExito.GetComponent<Panel>().nombre_producto = nombre_producto;
            PanelExito.SetActive(true);
        }
        else
        {
            PanelError.GetComponent<Panel>().nombre_producto = nombre_producto;
            PanelError.SetActive(true);
        }

    }


}