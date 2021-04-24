using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Cont : MonoBehaviour
{
    public float speed;
    public GameObject destroyedParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet") {

            Instantiate(destroyedParticle, this.transform.position, Quaternion.identity);
            //this.GetComponent<AudioSource>().Play();
            GameObject.FindObjectOfType<Game_Manager>().addScore(100);
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
