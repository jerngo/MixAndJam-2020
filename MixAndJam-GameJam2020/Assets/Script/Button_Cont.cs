using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Cont : MonoBehaviour
{
    public Color colorPressed;
    public Color colorNonPressed;

    public GameObject ButtonW;
    public GameObject ButtonA;
    public GameObject ButtonS;
    public GameObject ButtonD;

    public GameObject bullet;
    public GameObject bulletSpawn;

    public AudioSource beatAudioSource;

    public string Key;

    bool KeyOnTop;
    GameObject theNote;
    // Start is called before the first frame update
    void Start()
    {
        KeyOnTop = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "MusicNote") {
            KeyOnTop = true;
            theNote = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MusicNote")
        {
            KeyOnTop = false;
            if (theNote.GetComponent<MusicNote>().check == false) {
                theNote.GetComponent<MusicNote>().ChangeColor(false);
            }
            theNote = null;

        }
    }

    void checkKey() {
        if (KeyOnTop) {
            theNote.GetComponent<MusicNote>().ChangeColor(true);
            theNote.GetComponent<MusicNote>().check = true;
            beatAudioSource.Play();
            GameObject.FindObjectOfType<Game_Manager>().addScore(100);
            spawnBullet();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Key == "W") {
            if (Input.GetKeyDown(KeyCode.W))
            {
                ButtonW.GetComponent<SpriteRenderer>().color = colorPressed;
                checkKey();
                
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                ButtonW.GetComponent<SpriteRenderer>().color = colorNonPressed;
            }
        }

        if (Key == "A")
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ButtonA.GetComponent<SpriteRenderer>().color = colorPressed;
                checkKey();
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                ButtonA.GetComponent<SpriteRenderer>().color = colorNonPressed;
            }
        }


        if (Key == "S")
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                ButtonS.GetComponent<SpriteRenderer>().color = colorPressed;
                checkKey();
            }

            if (Input.GetKeyUp(KeyCode.S))
            {
                ButtonS.GetComponent<SpriteRenderer>().color = colorNonPressed;
            }
        }

        if (Key == "D")
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                ButtonD.GetComponent<SpriteRenderer>().color = colorPressed;
                checkKey();
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                ButtonD.GetComponent<SpriteRenderer>().color = colorNonPressed;
            }
        }

          
    }

    void spawnBullet() {
        Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity); 
    }
}
