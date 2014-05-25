using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


	private PlayerManager Manager;


	void Awake(){
		Manager=this.GetComponent<PlayerManager>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
