using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public Player player;

    public Text score;
    public Text timerText;
    public Text messageText;

    public Web web;
    private float timer;

    bool gameOn;

	// Use this for initialization
	void Start () {
        timer = 15.0f;
        gameOn = true;
        messageText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        if(gameOn == true)
        {
            score.text = "Score: " + player.getScore();

            timerText.text = "Time left: " + (float)Mathf.Floor(timer);
            timer -= Time.deltaTime;

            if(timer < 0)
            {
                StartCoroutine(stopGame());
            }
        }
    }

    IEnumerator stopGame()
    {
        gameOn = false;
        messageText.text = "Time is over!";
        yield return new WaitForSeconds(5);
        Application.LoadLevel(Application.loadedLevel);
    }
}
