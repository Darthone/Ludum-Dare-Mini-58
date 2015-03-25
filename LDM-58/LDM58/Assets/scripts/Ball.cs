using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Player LastHitter = null;
    [SerializeField] public float speedIncrease = 0.1f;
    [SerializeField] float startSpeed = 8f;
    Rigidbody2D rb; // = thisGetComponent<Rigidbody2D>();
	// Use this for initialization

	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(-startSpeed, Random.value * Random.value < .5 ? 1 : -1);
	}

    public void resetBall(int losingPlayer) {
        rb.MovePosition(new Vector2(0f, 0f));
        rb.velocity = GameManager.control.getDirection(losingPlayer) * startSpeed;
    }
	

	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision) {
        rb.velocity *= 1 + speedIncrease;
        if (collision.gameObject.tag == "Player") {
            LastHitter = collision.gameObject.GetComponent<Paddle>().owner;
        }
    }
}
