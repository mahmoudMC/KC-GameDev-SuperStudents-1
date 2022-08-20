using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballscript : MonoBehaviour
{
    bool win = false;
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10 && win == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(-10, 4, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("win"))
        {
            aud.Play();
            win = true;
            PlayerPrefs.SetInt("lvl", PlayerPrefs.GetInt("lvl") + 1);
            Invoke("mainmenuback", 1);
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(-10, 4, 0);
        }
    }

    void mainmenuback()
    {
        SceneManager.LoadScene(0);
    }
}
