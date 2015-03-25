using UnityEngine;
using System.Collections;

public class PaddleAI : MonoBehaviour {
    
    public bool SmartAI = false;
    float speedLimit = 0.75f; 
    public GameObject ballTarget;
    Paddle self;

	// Update is called once per frame
	void Update () {
        self = this.GetComponent<Paddle>();
	}

    void FixedUpdate() {
        if (SmartAI) {

        } else {
            self.rb.position += new Vector2(0, Mathf.Clamp( ballTarget.transform.position.y - self.rb.position.y, -self.MoveSpeed, self.MoveSpeed * speedLimit));
        }

        // if dumb ai, follow the coords of the ball
        // else find the trajectory of the bal
    }
}
