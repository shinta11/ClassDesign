using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainStageManager : Singlton<MainStageManager> {


	public GameObject InTitle;
	public GameObject InGame;
	public GameObject InGameOver;
	public GameObject Player;


	public enum EMainState{
		InTitle=0,
		InGame,				//プレイ中.
		InPause,			//ポーズ中.
		InGameOver,	//ゲームオーバー中.
		Exit,					//シーンの終了処理.
		MaxMainState,
	};


	public GameObject PlayerChara;
	

	public EMainState MainState;
	private EMainState NextMainState;

	//各ステートのときに使用するオブジェクトを入れる.
	Dictionary<EMainState, GameObject> Objects=new Dictionary<EMainState, GameObject>();

	
	void Awake() {
		
		if(this!=Instance) {
			Destroy(gameObject);
			return;
		}

		Objects.Add(EMainState.InTitle, InTitle);
		Objects.Add(EMainState.InGame, InGame);
		Objects.Add(EMainState.InGameOver, InGameOver);

		// 最初のステートは意味のないものにする.
		MainState=EMainState.MaxMainState;
	}


	void Update() {
		if(MainState != NextMainState) {
			MainState=NextMainState;

			//使用しないオブジェクトを非アクティブに.
			foreach(GameObject obj in Objects.Values) {
				obj.SetActive(false);
			}

			//現在のステートのときにオブジェクトを使用する場合はアクティブに.
			if(Objects.ContainsKey(MainState)) {
				GameObject tmp=Objects[MainState];
				tmp.SetActive(true);
			}
		}
	}


	/// <summary>
	/// ゲームの状態を更新する.
	/// </summary>
	/// <param name="nextState">Next state.</param>
	public void ChangeMainState(EMainState nextState) {
		NextMainState=nextState;
	}
}
