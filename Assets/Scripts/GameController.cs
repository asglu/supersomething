using UnityEngine;

public class GameController : MonoBehaviour
{
	bool debug = false;

	float yTouchLeft = 0.5f;
	float yTouchRight = 0.5f;
	float speedModifier = 0.5f;
	float directionModifier = 0.0f;

	MouseOrbitImproved orbit;

	void Start ()
	{
		Gesture.onDraggingStartE += DraggingStartHandler;
		Gesture.onDraggingE += DraggingHandler;
		Gesture.onDraggingEndE += DraggingEndHandler;
		orbit = gameObject.GetComponent<MouseOrbitImproved>();
	}

	// Update is called once per frame
	void Update ()
	{
		orbit.XModifier = directionModifier;
	}

	void DraggingStartHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====DraggingStartHandler====\n|| fingercount: " + dragInfo.fingerCount +
		                     " || index: " + dragInfo.index +
		                     " || isFlick: " + dragInfo.isFlick +
		                     " || pos: " + dragInfo.pos );
	}
	
	void DraggingHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====DraggingHandler====\n|| fingercount: " + dragInfo.fingerCount +
										" || index: " + dragInfo.index +
										" || isFlick: " + dragInfo.isFlick +
										" || pos: " + dragInfo.pos );


		if (dragInfo.pos.x / Screen.width <= 0.3)
		{
			yTouchLeft = dragInfo.pos.y / Screen.height;
			Debug.Log("Left: " + yTouchLeft );
		}

		if (dragInfo.pos.x / Screen.width >= 0.7)
		{
			yTouchRight = dragInfo.pos.y / Screen.height;
			Debug.Log("Right: " + yTouchRight );
		}

		speedModifier = (yTouchLeft >= yTouchRight) ? yTouchLeft : yTouchRight;

		directionModifier = yTouchLeft - yTouchRight;
		Debug.Log("Direction: " + directionModifier );


		//Debug.Log("orbit.XModifier: "+orbit.XModifier);
	}

	void DraggingEndHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====DraggingEndHandler====\n|| fingercount: " + dragInfo.fingerCount +
										" || index: " + dragInfo.index +
										" || isFlick: " + dragInfo.isFlick +
										" || pos: " + dragInfo.pos );
	
	}
}
