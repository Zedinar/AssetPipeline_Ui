using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Scene: MonoBehaviour {

    public bool GameStart = false;


    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0.0f;
    }
        
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Start_Game()
        {
            if (GameStart == false)
            {
                Time.timeScale = 1.0f;
                GameStart = true;
            }
        }
}
