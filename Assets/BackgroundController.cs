using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	//スクロール速度
	private float scrollSpeed = -0.03f;

	//背景の終了位置
	private float deadLine = -16f;

	//背景の開始位置
	private float startLine = 15.8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//背景移動
		transform.Translate (this.scrollSpeed, 0, 0);

		//画面外に出たら画面右端に移動する
		if (transform.position.x < this.deadLine) {

			transform.position = new Vector2(this.startLine, 0);
		}
	
	}
}
