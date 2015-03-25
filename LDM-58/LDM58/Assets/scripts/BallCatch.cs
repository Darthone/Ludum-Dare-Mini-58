using UnityEngine;
using System.Collections;

public class BallCatch : MonoBehaviour {
    Player owner;

	// Use this for initialization
	void Start () {
	    owner = this.transform.parent.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ball") {
            var oball = other.GetComponent<Ball>();
            if (oball.LastHitter != null)
                oball.LastHitter.score++;
            else {
                owner.score--;
            }
            oball.resetBall(owner.id);
        }
    }
}
