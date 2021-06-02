using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public Color colorcyan;
    public Color coloryellow;
    public Color colorpink;
    public Color colorpurple;

    public string currentColor;

    private void Start()
    {
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))

        {
            rb.velocity = Vector2.up * jumpForce; 


        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "colorchanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.tag != currentColor)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }


    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        if (index == 0)
        {
            currentColor = "Cyan";
            sr.color = colorcyan;
        }

        if (index ==1)
        {
            currentColor = "Yellow";
            sr.color = coloryellow;
        }

        if (index == 2)
        {
            currentColor = "purple";
            sr.color = colorpurple;
        }

        if (index == 3)
        {
            currentColor = "pink";
            sr.color = colorpink;

        }


    }
}
