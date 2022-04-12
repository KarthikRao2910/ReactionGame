using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
{

    public Text scoreText;
    public int score;

    private IcebergSpawner isp;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        isp = GetComponent<IcebergSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && isp.gameTime > 0)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(hit.transform.gameObject);
                score = score + 1;
                scoreText.text = score.ToString();
                isp.Spawn();
                StateScoreController.scoreStat = score;
            }
            if (hit.collider == null)
            {
                score = score - 1;
                scoreText.text = score.ToString();
                StateScoreController.scoreStat = score;
            }

        }

        if (isp.gameTime == 0)
        {
            //Invoke(SceneManager.LoadScene("RetryScene"), 2);
            //rsc.Setup(score);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
