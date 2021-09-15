using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarCirculo : MonoBehaviour
{

    public GameObject prefabCircle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            Instantiate(prefabCircle, new Vector3(12.36f, 6.92f, 0.0f), Quaternion.identity);
        }
    }
}
