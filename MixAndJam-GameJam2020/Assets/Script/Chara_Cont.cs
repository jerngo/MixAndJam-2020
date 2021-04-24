using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_Cont : MonoBehaviour
{
    public float speed;
    int health;

    public GameObject love1;
    public GameObject love2;
    public GameObject love3;
    public GameObject love4;
    public GameObject love5;

    public GameObject destroyed;
    // Start is called before the first frame update

    public Animator animCanvas;
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame

    private void Update()
    {
        if (health == 5) {
            love5.SetActive(true);
            love4.SetActive(true);
            love3.SetActive(true);
            love2.SetActive(true);
            love1.SetActive(true);

        }if (health == 4) {
            love5.SetActive(false);
            love4.SetActive(true);
            love3.SetActive(true);
            love2.SetActive(true);
            love1.SetActive(true);
        }
        if (health == 3)
        {
            love5.SetActive(false);
            love4.SetActive(false);
            love3.SetActive(true);
            love2.SetActive(true);
            love1.SetActive(true);
        }
        if (health == 2)
        {
            love5.SetActive(false);
            love4.SetActive(false);
            love3.SetActive(false);
            love2.SetActive(true);
            love1.SetActive(true);
        }
        if (health == 1)
        {
            love5.SetActive(false);
            love4.SetActive(false);
            love3.SetActive(false);
            love2.SetActive(false);
            love1.SetActive(true);
        }
        if (health == 0)
        {
            love5.SetActive(false);
            love4.SetActive(false);
            love3.SetActive(false);
            love2.SetActive(false);
            love1.SetActive(false);
        }
    }
    void FixedUpdate()
    {

        transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * (Time.deltaTime * speed);
    }

    public AudioSource gethit;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gethit.Play();
            health -= 1;
            if (health == 0) {
                love1.SetActive(false);
                Instantiate(destroyed, this.transform.position, Quaternion.identity);
                Debug.Log("You Lose");
                animCanvas.speed = 0;
                // this.GetComponent<AudioSource>().Play();
                this.GetComponent<EnableButton>().enableTarget();
                Destroy(this.gameObject);
            }
        }
    }
}
