using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorMonedas : MonoBehaviour
{
    public GameObject Coin;
    public float tiempoCreacion = 3f, RangoCreacion = 2f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Creando", 0.0f, tiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 0);

        GameObject Enemigo = Instantiate(Coin, SpawnPosition, Quaternion.identity);
    }
}
