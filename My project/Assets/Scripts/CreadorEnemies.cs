using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEnemies : MonoBehaviour
{

    public GameObject Enemy;
    public float tiempoCreacion = 2f, RangoCreacion = 2f;

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
        Vector3 SpawnPosition = new Vector3 (0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3 (SpawnPosition.x, this.transform.position.y, 0);

        GameObject Enemigo = Instantiate(Enemy, SpawnPosition, Quaternion.identity);
    }
}
