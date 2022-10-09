using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC {

	private string NPC_Name;
	private uint NPC_Age;
	private bool NPC_Romanceable;
	private int NPC_PlayerReputation;
	private int NPC_TavernReputation;
	private int NPC_Wealth;

	public NPC(string inName, uint inAge, bool inRomanceable, int inPlayerReputation, int inTavernReputation, int inWealth) {
		NPC_Name = inName;
		NPC_Age = inAge;
		NPC_Romanceable = inRomanceable;
		NPC_PlayerReputation = inPlayerReputation;
		NPC_TavernReputation = inTavernReputation;
		NPC_Wealth = inWealth;
	}
	
	//TODO: Getters and setters

	//put in local canInteract()
	public bool canAct() {
		//Will edit once dialogue is set up, to limit number of conversations to 1 per visit
		return true;
	}

	//put in Local Interact()
	public void Act() {

		Debug.Log("Fireye was too lazy to implement yarn!");
	}
}
