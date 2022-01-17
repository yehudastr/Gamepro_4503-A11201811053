using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject player;
	public float offsetXDist=2;
	private Vector3 offset;
    void Start()
    {
        offsetXDist+=player.transform.position.x;
		offset = transform.position - new Vector3(offsetXDist,0,0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
