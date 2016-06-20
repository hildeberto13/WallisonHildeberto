using UnityEngine;
using System.Collections;

public class Web : MonoBehaviour {
    public Player player;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void destroyWeb()
    {
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        Debug.Log("Destruído");
        player.setScore(10);
    }
}
