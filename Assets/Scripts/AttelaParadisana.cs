using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaParadisana : MonoBehaviour {
	public GameObject bean; 
	public GameObject car;
	public GameObject bear; 
	public GameObject lady;
	public GameObject attelaturetajs;
	public Sprite[] attelamasivs;
	public GameObject slider;

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

	public void izkritosais(int skaitlis){
		if (skaitlis == 0) {
			attelaturetajs.GetComponent<Image> ().sprite = attelamasivs [0];
		} else if (skaitlis == 1) {
			attelaturetajs.GetComponent<Image> ().sprite = attelamasivs [1];
		} else if (skaitlis == 2) {
			attelaturetajs.GetComponent<Image> ().sprite = attelamasivs [2];
		}
	}

	public void sliderSize(){
		float currentValue = slider.GetComponent<Slider> ().value;	
		attelaturetajs.transform.localScale = new Vector2 (1F*currentValue, 1F*currentValue);

	}
}
