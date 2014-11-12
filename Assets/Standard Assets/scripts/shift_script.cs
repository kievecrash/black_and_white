using UnityEngine;
using System.Collections;

public class shift_script : MonoBehaviour {
public bool isOn = false;
public float duration = 1.0F;
private bool isScaling = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			if(isOn){
				isOn = false;
				StartCoroutine (DoOtherScaleThing());
			}
			else{
				isOn = true;
				StartCoroutine (DoScaleThing());
			}
		}
	}


	public IEnumerator DoOtherScaleThing(){
		yield return new WaitForSeconds(0.5F);
		transform.localScale = new Vector3(0.00001F,0.00001F,0.00001F);
		yield break;
	}

	public IEnumerator DoScaleThing(){
		if (isScaling)
			yield break;

		isScaling = true;
		float startTime = Time.time;

		while (Time.time - startTime < duration){
			transform.localScale += new Vector3(0.05F,0.05F,0.05F);
			yield return null;
		}

//		for(int i = 1; i <= 1000; i ++){
//			transform.localScale += new Vector3((1/i),(1/i),(1/i));
//			yield return null;
//		}

		isScaling = false;
	}
}
