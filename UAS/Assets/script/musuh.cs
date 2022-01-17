using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musuh : MonoBehaviour
{
	int score = 5;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
		
		if(score==0){
			SceneManager.LoadScene("selesai");
		}
        
    }
	private void OnTriggerEnter2D(Collider2D other){
		
		if(other.gameObject.CompareTag("panahkita")){
			
			score--;
		}
	}
	void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label ("darah musuh "+score.ToString());
	}
	
}
