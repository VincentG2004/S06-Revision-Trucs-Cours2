using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationBronze : MonoBehaviour
{

        [SerializeField] GameObject _prefabOriginal;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 positionActuel = transform.position;
        Quaternion rotationActuel = transform.rotation;
        Instantiate(_prefabOriginal, positionActuel, rotationActuel);
       
    }
}
