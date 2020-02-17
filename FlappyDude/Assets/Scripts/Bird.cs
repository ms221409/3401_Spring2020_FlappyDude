using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float flapForce;
    public GameObject gameoverUI;

    int score = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("flap is working");

            //birdRigidbody.AddForce(Vector2.up * flapForce);
            birdRigidbody.velocity = Vector2.up * flapForce;
        }
    }


    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ScoreTag")
        {
            score += 1;
            Debug.Log(score);
        }
        else
        {
            gameoverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }


    public void OnRestartButtonPressed ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
