using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
	public AudioSource audioPlayer;
	private bool lostLife = false;

    private void Start()
    {
		Score.NextLife = Score.Lives - 1;
    }
    void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.tag == "Car")
        {
			audioPlayer.time = 0.69f; //Starts audio source at 0.69 seconds
			audioPlayer.Play();
        }
		if (col.tag == "Car" &&!lostLife)
		{
			lostLife = true;
			Score.Lives = Score.NextLife;
			Debug.Log("WE LOST!");
			Score.CurrentScore = 0;
			
			Invoke(nameof(RestartLevel), 0.2f); //Restarts level after 0.2 seconds

		}
	}

	void RestartLevel()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
