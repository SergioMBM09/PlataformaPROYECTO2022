using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonTienda : MonoBehaviour
{
    // Start is called before the first frame update
    public string Nombre_Producto;
    public int Precio_Producto;// entero o decimal?

    public void ComprarProducto()
    {
        Debug.Log("Estas comprando un " + Nombre_Producto);
        GameObject.Find("Tienda").GetComponent<Tienda>().Comprar(Precio_Producto, Nombre_Producto);

    }

}