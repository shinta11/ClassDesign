using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// インゲームのメイン処理.
/// </summary>
public class MainGame : Singlton<MainGame> {

	[SerializeField]
	public PlayerManager Player;

	// マネージャー管理リスト.
	private List<MoveObjectClass> ObjectList=new List<MoveObjectClass>();


	private GameObject PlayerChara;

	//Awake this instance
	void Awake() {

		if(this!=Instance){
			Destroy(gameObject);
			return;
		}
	}

	//Start this instance.
	void Start() {
		PlayerChara=MainStageManager.Instance.PlayerChara;

		ObjectList.Add(Player);

	}


	// オブジェクトの生成をする.
	void Update() {}

}
	