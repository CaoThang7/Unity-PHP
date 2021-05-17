using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerGame : MonoBehaviour
{
    private Animator player;

    public float speed = 5f;
    public float jump = 5f;

    public Text txtScore;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txtScore = GameObject.Find("txtScore").GetComponent<Text>();
        player = GetComponent<Animator>();
        
    }


    //Nhan vat cham vao Coin se bien mat Coin
    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Coin2")
        {
            score += 1;
            txtScore.text = "Score:" + score.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "CNV")
        {
            score -= 1;
            txtScore.text = "Score:" + score.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "doorwinner")
        {
            Application.LoadLevel("Menu");
        }
        if (other.gameObject.tag == "da1")
        {
            audiogame.PlaySound();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //di chuyen mui ten phai
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.SetBool("Run", true);//doi trang thai
            player.SetBool("Idel", false);
            //di chuyen
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            //quay dau
            if (gameObject.transform.localScale.x < 0)
            {
                gameObject.transform.localScale =
                    new Vector3(gameObject.transform.localScale.x * -1,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z);
            }
        }

        // di chuyen mui ten trai
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.SetBool("Run", true);
            player.SetBool("Idel", false);
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            //quay dau
            if (gameObject.transform.localScale.x > 0)
            {
                gameObject.transform.localScale =
                    new Vector3(gameObject.transform.localScale.x * -1,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z);
            }
        }
        //Nhay cao
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            player.SetBool("Run", true);
            player.SetBool("Idel", false);
            gameObject.GetComponent<Rigidbody2D>().velocity =
                new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, jump);
        }
        //ko an gi ca
        else
        {
            player.SetBool("Run", false);
            player.SetBool("Idel", true);
        }


    }
}
