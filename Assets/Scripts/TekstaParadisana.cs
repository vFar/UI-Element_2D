using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabás tekstu, kas panem no text field
	public string text;

	//Lauks no ka panemsu
	public GameObject inputField;
	//Objekts, kurs attelos inputField saturu
	public GameObject outputText;

	public void TextActions(){
		text = inputField.GetComponent<Text>().text;
		outputText.GetComponent<Text> ().text = "Sveiks, " + text.ToUpper()+" !";
	}



}
