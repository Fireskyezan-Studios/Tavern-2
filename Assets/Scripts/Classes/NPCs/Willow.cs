using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Willow : MonoBehaviour, IInteractable
{

    public NPC willow = new NPC("Willow", 35, true, 5, 5, 2);

    public bool canInteract() {
        return true;
    }

    public void Interact() {
        Debug.Log("Kai was too lazy to implement yarn!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
