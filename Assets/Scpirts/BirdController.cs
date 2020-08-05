using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    GameObject obj;
    public float flyPower;
    GameObject gameController;
    public AudioClip flyClip;
    public AudioClip gameoverClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        flyPower = 13;
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = flyClip;
        if(gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
            audioSource.Play();
        }
        
    }
    // end game
    void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }
    // add point
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().GetPoint();
    }
    void EndGame()
    {
        // Debug.Log("EndGame");
        audioSource.clip = gameoverClip;
        audioSource.Play();
        gameController.GetComponent<GameController>().EndGame();
    }
}
