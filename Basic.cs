using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{

    public Vector3 initPos; 

    public float yPos;

    public bool active;

    public float moveSpeed = 0.001f;

    public float startYPos;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
        initPos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        yPos = transform.position.y;
        startYPos = transform.position.y;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > startYPos + 0.5f || 
            transform.position.y < startYPos - 0.5f ||
            Input.GetKeyDown("space") == true
        ) {
            moveSpeed = -1 * moveSpeed;
        }

        yPos = yPos + moveSpeed;
        initPos = new Vector3(initPos.x,yPos,initPos.z);
        transform.position = initPos;
    }
}
