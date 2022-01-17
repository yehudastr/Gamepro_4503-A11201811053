using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panahmusuh : MonoBehaviour
{
	public GameObject panah;
	int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f,4f);
    }
	void CreateObstacle(){
		Instantiate (panah);
		score++;
		
		
	}

    // Update is called once per frame
    void Update()
    {
     if(score == 10 ){SceneManager.LoadScene("soal2");}   
    }
	
	void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label ("Score "+score.ToString());
	}
}
