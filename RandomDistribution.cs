using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDistribution : MonoBehaviour
{

    public GameObject plantPrefab;
    public float areaSize = 2.0f;
    public int amount = 20;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amount; i++) {
            Vector3 position = new Vector3(Random.Range(-1*areaSize, areaSize), 0, Random.Range(-1*areaSize, areaSize));
            GameObject Prefab = Instantiate(plantPrefab, position, Quaternion.identity);
            Prefab.transform.parent = gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
