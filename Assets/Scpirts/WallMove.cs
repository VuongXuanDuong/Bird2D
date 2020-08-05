using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float moveSpeeds;
    public float oldPositions;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        // obj = gameObject;
        oldPositions = 10;
        moveSpeeds = 3;
        minY = -4;
        maxY = -2;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.right * moveSpeeds * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("Vachamroi");
       if(other.gameObject.tag.Equals("ResetWall"))
        {
            transform.position = new Vector3(oldPositions, Random.Range(minY, maxY + 1), 0);

        }
    }
}
