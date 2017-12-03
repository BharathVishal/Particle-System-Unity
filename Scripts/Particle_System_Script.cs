using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Uses singleton pattern
public class  Particle_System_Script : MonoBehaviour 
{
	public static Particle_System_Script Instance;      
	public ParticleSystem current_ParticleSystem;
	public Transform current_TransPos;


	void Awake ()
	{
		//Check if there is already an instance of 
		if (Instance == null)
		{			
			//if not, set it to this.
			Instance = this;
			DontDestroyOnLoad (gameObject);

		}
		//If instance already exists:
		else if (Instance != this && Instance!=null)
		{
			//Destroy this, this enforces our singleton pattern.
			Destroy (gameObject);
		}
	}
		

	void Start()
	{
		
	}
		
	//Set the instance to null ondestroy
	void OnDestroy()
	{
		if (Instance == this)
		{
			Instance = null;
		}
	}
}
