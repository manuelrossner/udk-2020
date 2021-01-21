using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public GameObject fishPrefab;
    public Vector3 fishPos;
    

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 20; i++) {
            Instantiate(fishPrefab, fishPos, Quaternion.identity);   
            fishPos = new Vector3(fishPos.x, fishPos.y + 3.2f, fishPos.z + 0.1f);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
