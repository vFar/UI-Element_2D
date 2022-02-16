using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttelaParadisana : MonoBehaviour {
	public GameObject bean; 
	public GameObject car;
	public GameObject bear; 
	public GameObject lady;

	public void beanShow(bool variable){
		bean.SetActive (variable);
	}

	public void carShow(bool variable){
		car.SetActive (variable);
	}

	public void bearShow(bool variable){
		bear.SetActive (variable);
	}

	public void ladyShow(bool variable){
		lady.SetActive (variable);
	}

	public void LeftTurnBean(){
		bean.transform.localScale = new Vector2 (1, 1);
	}

	public void RightTurnBean(){
		bean.transform.localScale = new Vector2 (-1, 1);
	}
}
