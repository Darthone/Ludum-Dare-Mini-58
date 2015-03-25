using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager control = null;
    public int numberPlayers = 2;

    void Awake() {
        if (control == null) {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this) {
            Destroy(gameObject);
            return;
        }
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
    }

    public Vector3 getDirection(int lastPlayer) {
        Vector3 dir = new Vector3();
        switch(lastPlayer){
            case 0: // left
                dir = new Vector3(1f, 0f);
                break;
            case 1: // right
                dir = new Vector3(-1f, 0f);
                break;
            case 2: // top
                dir = new Vector3(0f, 1f);
                break;
            case 3: //bottom
                dir = new Vector3(0f, -1f);
                break;
        }
        return dir;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
