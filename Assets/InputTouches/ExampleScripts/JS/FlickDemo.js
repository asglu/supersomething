#pragma strict

	public var source:Transform;
	public var shootObject:GameObject;
	public var forceModifier:float=1;
	
	
	function OnEnable(){
		Gesture.onSwipeStartE += OnSwipeStart;
		Gesture.onSwipeEndE += OnSwipeEnd;
		
		Gesture.onSwipeE += OnSwipe;
		
		Gesture.onSwipingE += OnSwiping;
	}
	
	function OnSwiping(sw:SwipeInfo){
		
	}
	
	function OnDisable(){
		Gesture.onSwipeStartE += OnSwipeStart;
		Gesture.onSwipeEndE += OnSwipeEnd;
		
		Gesture.onSwipeE += OnSwipe;
		
		Gesture.onSwipingE -= OnSwiping;
	}
	
	//when a swipe has started, valid or not
	//if the starting position is on the source(turret), scale it up to give some visual feedback
	function OnSwipeStart(sw:SwipeInfo){
		var ray:Ray = Camera.main.ScreenPointToRay(sw.startPoint);
		var hit:RaycastHit;
		if(Physics.Raycast(ray, hit, Mathf.Infinity)){
			if(hit.transform==source){
				source.localScale=Vector3(2.2, 2.2, 2.2);
			}
		}
	}
	
	//when a swipe has end, valid or not
	function OnSwipeEnd(sw:SwipeInfo){
		//make sure we adjust the source(turret) scale back to original
		source.localScale=Vector3(1.8, 1.8, 1.8);
	}
	
	//when a valide swipe is confirm
	function OnSwipe(sw:SwipeInfo){
		var ray:Ray = Camera.main.ScreenPointToRay(sw.startPoint);
		var hit:RaycastHit;
		//use raycast at the cursor position to detect the object
		if(Physics.Raycast(ray, hit, Mathf.Infinity)){
			//only if the swipe is started from the source(turret) location 
			if(hit.transform==source){
				//instatiate a new shootObject
				var shootObjInstance:GameObject=Instantiate(shootObject, source.TransformPoint(Vector3(0, 0.5, 0.5)), Quaternion.identity);
				
				var force:float;
				
				//if using siwpe magnitude as force determining factor
				if(forceFactor==0){
					//calculate the force, clamp the value between 50 and 2200 so that it's not too slow or too fast that the shootObject is not visible
					force=Mathf.Clamp(sw.direction.magnitude*forceModifier*1.5f, 50, 2200);
					//normalize the direction
					sw.direction.Normalize();
					//apply the force according to the direction
					shootObjInstance.rigidbody.AddForce(Vector3(sw.direction.x, sw.direction.y, 0)*force);
				}
				//if using siwpe speed as force determining factor
				else if(forceFactor==1){
					//calculate the force, clamp the value between 50 and 2200 so that it's not too slow or too fast that the shootObject is not visible
					force=Mathf.Clamp(sw.speed*forceModifier*1f, 50, 2200);
					//normalize the direction
					sw.direction.Normalize();
					//apply the force according to the direction
					shootObjInstance.rigidbody.AddForce(Vector3(sw.direction.x, sw.direction.y, 0)*force);
				}
				
				//make sure the shootObject is destroy after 3 second
				Destroy(shootObjInstance, 3);
			}
		}
	}
	
	
	private var instruction:boolean=false;
	function OnGUI(){
		var title:String="Shoot the target!!";
		GUI.Label(Rect(150, 15, 500, 40), title);
		
		if(!instruction){
			if(GUI.Button(Rect(10, 55, 130, 35), "Instruction On")){
				instruction=true;
			}
		}
		else{
			if(GUI.Button(Rect(10, 55, 130, 35), "Instruction Off")){
				instruction=false;
			}
			
			GUI.Box(Rect(10, 100, 330, 65), "");
			
			GUI.Label(Rect(15, 105, 320, 65), "- press on the fire button and flick it towards a target\n- the flick direction and speed will determine the firing angle and force");
		}		
	}
	
	private var forceFactor:int=1;