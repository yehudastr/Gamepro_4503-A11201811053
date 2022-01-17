using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class control2 : MonoBehaviour
{
	public float speed = 10.5f;
	
	public float min_y , max_y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
	void MovePlayer(){
		if(Input.GetAxisRaw("Vertical")>0f){
			Vector3 temp = transform.position;
			temp.y += speed * Time.deltaTime;
			if(temp.y > max_y){
				temp.y = max_y;
			}
			transform.position = temp;
		} else if(Input.GetAxisRaw("Vertical")<0f){
			Vector3 temp = transform.position;
			temp.y -= speed * Time.deltaTime;
			if(temp.y < min_y){
				temp.y = min_y;
			}
			transform.position = temp;
		}
	}
	private void OnTriggerEnter2D(Collider2D other){
		
		if(other.gameObject.CompareTag("panahmusuh")){
			SceneManager.LoadScene("level2gagal");
		}
	}
	
}
