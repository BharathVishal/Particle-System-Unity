using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Resources_Holder_Singleton : MonoBehaviour {


	    [Header("Particle Materials Related")]
     	[Space(15)]
	    public Material one_Of_Eight;
	    public Material two_Of_Eight;
     	public Material three_Of_Eight;
	    public Material four_Of_Eight;
	    public Material five_Of_Eight;
	    public Material six_Of_Eight;
	    public Material seven_Of_Eight;
	    public Material eight_Of_Eight;


	    [Header("Current Index")]
	    [Space(15)]
	    int cur_Index_For_Particles;



	     [Header("UI Object")]
	    [Space(15)]
	    public GameObject text_Obj;
	    public Text particle_Index_Text;



    //Singleton Logic
	public static Resources_Holder_Singleton Instance;       


	void Awake ()
	{
		if (Instance == null)
		{			
			//if not, set it to this.
			Instance = this;
			DontDestroyOnLoad (gameObject);
		}
		else if (Instance != this  && Instance!=null)
	    {
			Destroy (gameObject);
		}
	}
		

	//Call this at start
	public void init_Particle_System_Obj()
	{
		cur_Index_For_Particles = 0;
		particle_Index_Text.text = "Current Particle Index : 0";

		ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

		var tempPart_Main = tempPartsys.main;
		var tempPart_Emission = tempPartsys.emission;
		var tempPart_Shape = tempPartsys.shape;
		var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
		var tempPart_Noise = tempPartsys.noise;



		//Setting values 
		tempPart_Main.startLifetime = 5.0f;
		tempPart_Main.maxParticles = 38;
		tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
		tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.05f, 0.05f);
		tempPart_Main.startRotation = 0.0f;


		tempPart_Emission.rateOverTime = 20.0f;
		tempPart_Emission.rateOverDistance = 0.0f;

		tempPart_Shape.shapeType = ParticleSystemShapeType.Box;
		tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
		tempPart_Shape.randomDirectionAmount = 1.0f;



		tempPart_ColorOverLifeTime.enabled = true;
		Gradient grad = new Gradient ();
		//new gradientkey(alpha,time)
		grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
			new GradientColorKey (Color.white, 1.0f)
		}, 
			new GradientAlphaKey[] {
				new GradientAlphaKey (0.0f, 0.0f),
				new GradientAlphaKey (0.93f, 0.5f),
				new GradientAlphaKey (0.0f, 1.0f)
			});
		tempPart_ColorOverLifeTime.color = grad;



		tempPart_Noise.enabled = false;
		tempPart_Noise.strength = new ParticleSystem.MinMaxCurve (0.0f, 0.0f);
		tempPart_Noise.frequency = 10.0f;


		Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = one_Of_Eight;
		Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
		Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
		Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.03f;


		Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -7.87f, 7.52f);
		Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (0.0f, 0.0f, 0.0f));
	}



	//Call this when the index is changed
	public void update_Particle_System_Obj()
	{
			if (cur_Index_For_Particles == 0) 
		    {
			    particle_Index_Text.text = "Current Particle Index : 0";

				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 38;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.05f, 0.05f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 20.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Box;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;


			
				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (0.93f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;



				tempPart_Noise.enabled = false;
				tempPart_Noise.strength = new ParticleSystem.MinMaxCurve (0.0f, 0.0f);
				tempPart_Noise.frequency = 10.0f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = one_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.03f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -7.87f, 7.52f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (0.0f, 0.0f, 0.0f));

			} else if (cur_Index_For_Particles ==1) {
			    particle_Index_Text.text = "Current Particle Index : 1";

		
				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 34;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.05f, 0.05f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 18.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Box;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;


				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (0.93f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;



				tempPart_Noise.enabled = false;
				tempPart_Noise.strength = new ParticleSystem.MinMaxCurve (0.0f, 0.0f);
				tempPart_Noise.frequency = 10.0f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = two_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.0125f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -7.87f, 7.52f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (0.0f, 0.0f, 0.0f));

			} 
			else if (cur_Index_For_Particles ==2) {
			    particle_Index_Text.text = "Current Particle Index : 2";


				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 34;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.60f, 0.90f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 12.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Cone;
				tempPart_Shape.angle = 25.0f;
				tempPart_Shape.radius = 0.54f;
				tempPart_Shape.length = 5.0f;
				tempPart_Shape.randomDirectionAmount = 1.0f;


				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (1.00f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;


				tempPart_Noise.enabled = true;
				tempPart_Noise.strength = 0.001f;
				tempPart_Noise.frequency = 5.12f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = three_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.035f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -9.21f, 10.00f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (-180.0f, 0.0f, 0.0f));

			} else if (cur_Index_For_Particles ==3) {
	           particle_Index_Text.text = "Current Particle Index : 3";

				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 30;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.50f, 1.00f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.60f, 0.90f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 10.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Cone;
				tempPart_Shape.angle = 25.0f;
				tempPart_Shape.radius = 0.54f;
				tempPart_Shape.length = 5.0f;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;


				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (1.00f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;


				tempPart_Noise.enabled = true;
				tempPart_Noise.strength = 0.001f;
				tempPart_Noise.frequency = 5.12f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = four_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.0138f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -9.21f, 10.00f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (-180.0f, 0.0f, 0.0f));

			}

			else if (cur_Index_For_Particles==4) {
			    particle_Index_Text.text = "Current Particle Index : 4";


				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 30;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.60f, 0.90f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 10.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Cone;
				tempPart_Shape.angle = 25.0f;
				tempPart_Shape.radius = 0.54f;
				tempPart_Shape.length = 5.0f;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;


				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (1.00f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;


				tempPart_Noise.enabled = true;
				tempPart_Noise.strength = 0.001f;
				tempPart_Noise.frequency = 5.12f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = five_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.041f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -9.21f, 10.00f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (-180.0f, 0.0f, 0.0f));

			} else if (cur_Index_For_Particles==5) {
			    particle_Index_Text.text = "Current Particle Index : 5";


				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 30;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.60f, 0.90f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 10.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Cone;
				tempPart_Shape.angle = 25.0f;
				tempPart_Shape.radius = 0.54f;
				tempPart_Shape.length = 5.0f;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;


				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (1.00f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;


				tempPart_Noise.enabled = true;
				tempPart_Noise.strength = 0.001f;
				tempPart_Noise.frequency = 5.12f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = six_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.035f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -9.21f, 10.00f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (-180.0f, 0.0f, 0.0f));

			}

			else if (cur_Index_For_Particles==6) {
			    particle_Index_Text.text = "Current Particle Index : 6";


				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 34;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.05f, 0.05f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 18.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Box;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;


				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (0.93f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;



				tempPart_Noise.enabled = false;
				tempPart_Noise.strength = new ParticleSystem.MinMaxCurve (0.0f, 0.0f);
				tempPart_Noise.frequency = 10.0f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = seven_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.0125f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -7.87f, 7.52f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (0.0f, 0.0f, 0.0f));

			} else if (cur_Index_For_Particles==7) {
			    particle_Index_Text.text = "Current Particle Index : 7";


				ParticleSystem tempPartsys = Particle_System_Script.Instance.current_ParticleSystem;

				var tempPart_Main = tempPartsys.main;
				var tempPart_Emission = tempPartsys.emission;
				var tempPart_Shape = tempPartsys.shape;
				var tempPart_ColorOverLifeTime = tempPartsys.colorOverLifetime;
				var tempPart_Noise = tempPartsys.noise;



				//Setting values 
				tempPart_Main.startLifetime = 5.0f;
				tempPart_Main.maxParticles = 38;
				tempPart_Main.startSize = new ParticleSystem.MinMaxCurve (0.5f, 1.0f);
				tempPart_Main.startSpeed = new ParticleSystem.MinMaxCurve (0.05f, 0.05f);
				tempPart_Main.startRotation = 0.0f;


				tempPart_Emission.rateOverTime = 20.0f;
				tempPart_Emission.rateOverDistance = 0.0f;

				tempPart_Shape.shapeType = ParticleSystemShapeType.Box;
				tempPart_Shape.scale = new Vector3 (12.69f, 7.83f, 8.88f);
				tempPart_Shape.randomDirectionAmount = 1.0f;



				tempPart_ColorOverLifeTime.enabled = true;
				Gradient grad = new Gradient ();
				//new gradientkey(alpha,time)
				grad.SetKeys (new GradientColorKey[] { new GradientColorKey (Color.white, 0.0f), new GradientColorKey (Color.white, 0.5f),
					new GradientColorKey (Color.white, 1.0f)
				}, 
					new GradientAlphaKey[] {
						new GradientAlphaKey (0.0f, 0.0f),
						new GradientAlphaKey (0.93f, 0.5f),
						new GradientAlphaKey (0.0f, 1.0f)
					});
				tempPart_ColorOverLifeTime.color = grad;



				tempPart_Noise.enabled = false;
				tempPart_Noise.strength = new ParticleSystem.MinMaxCurve (0.0f, 0.0f);
				tempPart_Noise.frequency = 10.0f;


				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().sharedMaterial = eight_Of_Eight;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().normalDirection = 1.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().minParticleSize = 0.0f;
				Particle_System_Script.Instance.current_ParticleSystem.GetComponent<ParticleSystemRenderer> ().maxParticleSize = 0.03f;


				Particle_System_Script.Instance.current_TransPos.position = new Vector3 (3.2f, -7.87f, 7.52f);
				Particle_System_Script.Instance.current_TransPos.rotation = Quaternion.Euler (new Vector3 (0.0f, 0.0f, 0.0f));
			} 
		} //End of Method




     // Use this for initialization
	void Start () 
	{
		particle_Index_Text=text_Obj.GetComponent<Text> ();
		init_Particle_System_Obj ();
	}



	void Update()
	{
		
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			if (cur_Index_For_Particles > 1) {
				--cur_Index_For_Particles;
				update_Particle_System_Obj ();
			}
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{	
			if (cur_Index_For_Particles < 7) {
				++cur_Index_For_Particles;
				update_Particle_System_Obj ();
			}
		}
	}




	//Set the instance to null ondestroy
	void OnDestroy()
	{
		if (Instance == this) 
			Instance = null;
	}

}
