using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public GameObject[] sto;
    public GameObject aim;
    public Rigidbody2D rb;
    public GameObject draw;
    public TextMeshProUGUI scoreTx;
    public TextMeshProUGUI final;

    int rot;
    bool movee = false;

    int score;

    int pos = 5;
    int neg = -5;

     int stage = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void resta()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2((aim.transform.position.x - transform.position.x) * 2, (aim.transform.position.y - transform.position.y) * 2);
            aim.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        if(rb.velocity == new Vector2(0, 0))
        {
            transform.Rotate(new Vector3(0, 0, rot));
        } else
        {
            Instantiate(draw, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        }
        if (stage == 0)
        {
            if (transform.eulerAngles.z >= 0 && transform.eulerAngles.z < 100)
            {
                rot = neg;
            }
            if (transform.eulerAngles.z > 270 && transform.eulerAngles.z <= 300)
            {
                rot = pos;
            }
            if (transform.position.x >= sto[stage].transform.position.x)
            {
                transform.eulerAngles =  new Vector3(0,0,270);
                if (((transform.position.x - sto[stage].transform.position.x) <= 1 && (transform.position.x - sto[stage].transform.position.x) >= -1)
                    && (transform.position.y - sto[stage].transform.position.y) <= 1 && (transform.position.y - sto[stage].transform.position.y) >= -1)
                {
                    score += (int)((((1- Mathf.Abs(transform.position.x - sto[stage].transform.position.x))/2)+((1 - Mathf.Abs(transform.position.y - sto[stage].transform.position.y) )/ 2))*100);
                    if (score < 100)
                    {
                        scoreTx.text = "score: 0" + score.ToString();
                    }
                    else
                    {
                        scoreTx.text = "score: " + score.ToString();
                    }
                }
                rb.velocity = new Vector2(0, 0);
                aim.SetActive(true);
                stage++;
            }
        } else if (stage == 1)
        {
            if (transform.eulerAngles.z >= 300)
            {
                rot = neg;
            }
            if (transform.eulerAngles.z <= 240)
            {
                rot = pos;
            }
            if (transform.position.y <= sto[stage].transform.position.y)
            {
                transform.eulerAngles = new Vector3(0, 0, 210);
                if (((transform.position.x - sto[stage].transform.position.x) <= 1 && (transform.position.x - sto[stage].transform.position.x) >= -1)
                    && (transform.position.y - sto[stage].transform.position.y) <= 1 && (transform.position.y - sto[stage].transform.position.y) >= -1)
                {
                    score += (int)((((1 - Mathf.Abs(transform.position.x - sto[stage].transform.position.x)) / 2) + ((1 - Mathf.Abs(transform.position.y - sto[stage].transform.position.y)) / 2)) * 100);
                    if (score < 100)
                    {
                        scoreTx.text = "score: 0" + score.ToString();
                    }
                    else
                    {
                        scoreTx.text = "score: " + score.ToString();
                    }
                }
                rb.velocity = new Vector2(0, 0);
                aim.SetActive(true);
                stage++;
            }
        } else if (stage == 2)
        {
            if (transform.eulerAngles.z >= 240)
            {
                rot = neg;
            }
            if (transform.eulerAngles.z <= 180)
            {
                rot = pos;
            }
            if (transform.position.x <= sto[stage].transform.position.x)
            {
                transform.eulerAngles = new Vector3(0, 0, 150);
                if (((transform.position.x - sto[stage].transform.position.x) <= 1 && (transform.position.x - sto[stage].transform.position.x) >= -1)
                    && (transform.position.y - sto[stage].transform.position.y) <= 1 && (transform.position.y - sto[stage].transform.position.y) >= -1)
                {
                    score += (int)((((1 - Mathf.Abs(transform.position.x - sto[stage].transform.position.x)) / 2) + ((1 - Mathf.Abs(transform.position.y - sto[stage].transform.position.y)) / 2)) * 100);
                    if (score < 100)
                    {
                        scoreTx.text = "score: 0" + score.ToString();
                    }
                    else
                    {
                        scoreTx.text = "score: " + score.ToString();
                    }
                }
                rb.velocity = new Vector2(0, 0);
                aim.SetActive(true);
                stage++;
            }
        } else if (stage == 3)
        {
            if (transform.eulerAngles.z >= 180)
            {
                rot = neg;
            }
            if (transform.eulerAngles.z <= 120)
            {
                rot = pos;
            }
            if (transform.position.x <= sto[stage].transform.position.x)
            {
                transform.eulerAngles = new Vector3(0, 0, 90);
                if (((transform.position.x - sto[stage].transform.position.x) <= 1 && (transform.position.x - sto[stage].transform.position.x) >= -1)
                    && (transform.position.y - sto[stage].transform.position.y) <= 1 && (transform.position.y - sto[stage].transform.position.y) >= -1)
                {
                    score += (int)((((1 - Mathf.Abs(transform.position.x - sto[stage].transform.position.x)) / 2) + ((1 - Mathf.Abs(transform.position.y - sto[stage].transform.position.y)) / 2)) * 100);
                    if (score < 100)
                    {
                        scoreTx.text = "score: 0" + score.ToString();
                    }
                    else
                    {
                        scoreTx.text = "score: " + score.ToString();
                    }
                }
                rb.velocity = new Vector2(0, 0);
                aim.SetActive(true);
                stage++;
            }
        } else if (stage == 4)
        {
            if (transform.eulerAngles.z >= 120)
            {
                rot = neg;
            }
            if (transform.eulerAngles.z <= 60)
            {
                rot = pos;
            }
            if (transform.position.y >= sto[stage].transform.position.y)
            {
                transform.eulerAngles = new Vector3(0, 0, 30);
                if (((transform.position.x - sto[stage].transform.position.x) <= 1 && (transform.position.x - sto[stage].transform.position.x) >= -1)
                    && (transform.position.y - sto[stage].transform.position.y) <= 1 && (transform.position.y - sto[stage].transform.position.y) >= -1)
                {
                    score += (int)((((1 - Mathf.Abs(transform.position.x - sto[stage].transform.position.x)) / 2) + ((1 - Mathf.Abs(transform.position.y - sto[stage].transform.position.y)) / 2)) * 100);
                    if (score < 100)
                    {
                        scoreTx.text = "score: 0" + score.ToString();
                    }
                    else
                    {
                        scoreTx.text = "score: " + score.ToString();
                    }
                }
                rb.velocity = new Vector2(0, 0);
                aim.SetActive(true);
                stage++;
            }
        } else if (stage == 5)
        {
            if (transform.eulerAngles.z >= 60)
            {
                rot = neg;
            }
            if (transform.eulerAngles.z <= 1)
            {
                rot = pos;
            }
            if (transform.position.x >= sto[stage].transform.position.x)
            {
                rb.velocity = new Vector2(0, 0);
                if (((transform.position.x - sto[stage].transform.position.x) <= 1 && (transform.position.x - sto[stage].transform.position.x) >= -1)
                    && (transform.position.y - sto[stage].transform.position.y) <= 1 && (transform.position.y - sto[stage].transform.position.y) >= -1)
                {
                    score += (int)((((1 - Mathf.Abs(transform.position.x - sto[stage].transform.position.x)) / 2) + ((1 - Mathf.Abs(transform.position.y - sto[stage].transform.position.y)) / 2)) * 100);
                }
                scoreTx.gameObject.SetActive(false);
                final.text = "Final Score: " + score + "/600";
                final.gameObject.SetActive(true);



                stage++;
            }
        }
    }
}
