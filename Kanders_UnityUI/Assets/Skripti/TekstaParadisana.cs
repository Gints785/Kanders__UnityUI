using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabas tekstu, kurs panemnts no input lauka
	public string teksts;
	public int cipars;
	// lauks no, kura es tekstu panemsu
	public GameObject ievadesLauks,ievadesLauks1;
	//Teksta objekts, kur attelot mainiga teksta saturu
	public GameObject tekstaAttelasanasLauks;

	public void darbibasArTeksu(){
		
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelasanasLauks.GetComponent<Text> ().text = " " + teksts.ToUpper () + "";
	}

	











}
