using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptpanahkita : MonoBehaviour
{
	
	public float speed = 5f;
	public float deactivate_timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Move(); 
    }
	void Move(){
		Vector3 temp = transform.position;
		
		temp.x += speed * Time.deltaTime;
		transform.position = temp;
		
		
		
	}
	     
}
