using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
	//returns true if Object can be interacted with
	public bool canInteract();

	//Triggered on interact
	public void Interact();

}
