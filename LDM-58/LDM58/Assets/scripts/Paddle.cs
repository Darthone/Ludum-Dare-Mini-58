using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    public Player owner;
    public float MoveSpeed = .7f;
    public string LeftButtonName = "Left";
    public string RightButtonName = "Right";
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        owner = this.transform.parent.GetComponent<Player>();
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {
        if (LeftButtonName != "" && RightButtonName != "") {
            if (Input.GetButton(LeftButtonName)) {
                //rb.AddForce(new Vector2(0f, 200f));
                //this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(0f, MoveSpeed));
                //this.transform.position += new Vector3(0f,MoveSpeed);
                rb.position += new Vector2(0f, MoveSpeed);
                if (rb.position.y > 17f)
                    rb.position = new Vector2(rb.position.x, 17f);
            }
            else if (Input.GetButton(RightButtonName)) {
                //rb.AddForce(new Vector2(0f, -200f));
                //this.GetComponent<Rigidbody2D>().MovePosition(new Vector2(0f, -MoveSpeed));
                //this.transform.position -= new Vector3(0f, MoveSpeed);
                rb.position -= new Vector2(0f, MoveSpeed);
                if (rb.position.y < -17f)
                    rb.position = new Vector2(rb.position.x, -17f);
            }
        }
    }
}
