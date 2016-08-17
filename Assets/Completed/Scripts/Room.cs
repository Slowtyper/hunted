using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/*
[System.Serializable]
public class Room : MonoBehaviour {
    public List<Room> neighboringRooms;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}*/

[System.Serializable]
public class Room : MonoBehaviour
{
    public void Transition(Room room)
    {
        // Call the actions to take on leave
        OnTransitionLeave();
        gameObject.SetActive(false);

        // Call the actions to take when entering the room
        room.gameObject.SetActive(true);
        room.OnTransitionEnter();
    }

    public void OnTransitionEnter()
    {
        // Currently doing nothing... meant to be overridden
    }
    public void OnTransitionLeave()
    {
        // Currently doing nothing... meant to be overridden
    }
}
