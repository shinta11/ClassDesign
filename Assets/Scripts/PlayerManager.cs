using UnityEngine;
using System.Collections;

public class PlayerManager : MoveObjectClass {


	public GameObject PlayerChara;


	public CharacterParam Param;


	private PlayerMove Move;


	void Awake() {

		Move=this.GetComponent<PlayerMove>();
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
