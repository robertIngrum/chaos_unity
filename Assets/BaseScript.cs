using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    public Transform prefab;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 prefabLocation = transform.position + new Vector3(0, 10, 0);
        Instantiate(prefab, prefabLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
