using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elite_Cont : MonoBehaviour
{
    public float speed;
    public GameObject destroyedParticle;
    public float topLimit;
    public float botLimit;

    // Start is called before the first frame update
    void Start()
    {

    }

    int direction = 1;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y >= topLimit) {
            direction = -1;
        }
        if (transform.position.y <= botLimit)
        {
            direction = 1;
        }

        transform.Translate((Vector3.up*direction) * speed * Time.deltaTime);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {

            Instantiate(destroyedParticle, this.transform.position, Quaternion.identity);
            //this.GetComponent<AudioSource>().Play();
            GameObject.FindObjectOfType<Game_Manager>().addScore(1000);
            Destroy(this.gameObject);

        }

        if (collision.gameObject.tag == "Player")
        {

            Instantiate(destroyedParticle, this.transform.position, Quaternion.identity);
            //this.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);

        }
    }
}
