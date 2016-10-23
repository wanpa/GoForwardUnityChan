using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadline = -10;
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		//画面外い出たら破棄する
		if (transform.position.x < this.deadline) {
			Destroy(gameObject);
		}
	
	}
}
