using UnityEngine;
using System.Collections;

public class plat_toggle : MonoBehaviour {
	public bool isActive = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			if(isActive){
				this.collider.enabled =false;
				isActive = false;
			}
			else{
				this.collider.enabled = true;
				isActive = true;
			}
		}
	}
}
