using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudMove : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
  //  private GameObject obj;
    private Vector3 oldPosition;

    // Start is called before the first frame update
    void Start()
    {
       // obj = gameObject;
       oldPosition = transform.position;
        moveSpeed = 3;
        moveRange = 20;
    }
    // Update is called once per frame
    void Update()
    {   
        transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        if(Vector3.Distance(oldPosition,transform.position)>moveRange)
        {
            transform.position = oldPosition;
        }
    }
}
