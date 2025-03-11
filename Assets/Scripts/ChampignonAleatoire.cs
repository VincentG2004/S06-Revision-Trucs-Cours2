using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampignonAleatoire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         float _random = Random.value;
      
        if (_random <= 0.5f) 
        {
        transform.position = new Vector3(2.5f,1f,-4.365f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
