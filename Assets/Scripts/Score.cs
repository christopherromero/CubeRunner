using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

	// Update is called once per frame
	void Update () {
        if (!FindObjectOfType<GameManager>().GetGameHasEnded())
        {
            scoreText.text = player.position.z.ToString("0");
        }
	}
}
