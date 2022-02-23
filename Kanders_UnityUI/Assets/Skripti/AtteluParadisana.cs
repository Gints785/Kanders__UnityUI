using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

	public GameObject Steve;
	public GameObject Zombie;

	public GameObject Helmet;
	public GameObject ChestPlate;
	public GameObject Pants;
	public GameObject Boots;


	public void HelmetParad(bool vertiba){
		Helmet.SetActive (vertiba);
	}
	public void ChestPlateParad(bool vertiba){
		ChestPlate.SetActive (vertiba);
	}

	public void PantsParad(bool vertiba){
		Pants.SetActive (vertiba);
	}

	public void BootsParad(bool vertiba){
		Boots.SetActive (vertiba);
	}
	public void paKreisiSteve(bool vertiba){
		
		Steve.SetActive (vertiba);
	}
	public void paLabiZombie(bool vertiba){
		Zombie.SetActive (vertiba);
	}



}
