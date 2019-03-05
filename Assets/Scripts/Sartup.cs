using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sartup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.position.ToString());
        gameObject.transform.position = new Vector3(-100, gameObject.transform.position.y, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
