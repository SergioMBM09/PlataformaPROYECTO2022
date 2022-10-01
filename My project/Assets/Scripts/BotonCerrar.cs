using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCerrar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloseWindow()
    {
        transform.parent.parent.gameObject.SetActive(false);
    }
}