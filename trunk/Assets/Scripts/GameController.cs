using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	bool debug = true;
	// Use this for initialization
	void Start ()
	{
		Gesture.onDraggingE += DraggingHandler;
		//Gesture.onMFDraggingE += MFDraggingHandler;
		Gesture.onDraggingStartE += DraggingStartHandler;
		Gesture.onDraggingEndE += DraggingEndHandler;
		//Gesture.onMFDraggingStartE += MFDraggingStartHandler;
		//Gesture.onMFDraggingEndE += MFDraggingEndHandler;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void DraggingHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====DraggingHandler====\n|| fingercount: " + dragInfo.fingerCount +
										" || index: " + dragInfo.index +
										" || isFlick: " + dragInfo.isFlick +
										" || pos: " + dragInfo.pos );
		
	}

	void MFDraggingHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====MFDraggingHandler====\n|| fingercount: " + dragInfo.fingerCount +
		          "\n|| index: " + dragInfo.index +
		          "\n|| isFlick: " + dragInfo.isFlick +
		          "\n|| pos: " + dragInfo.pos );

	}


	void DraggingStartHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====DraggingStartHandler====\n|| fingercount: " + dragInfo.fingerCount +
		          "\n|| index: " + dragInfo.index +
		          "\n|| isFlick: " + dragInfo.isFlick +
		          "\n|| pos: " + dragInfo.pos );
	}
	
	void DraggingEndHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====DraggingEndHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
	
	void MFDraggingStartHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====MFDraggingStartHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
	
	void MFDraggingEndHandler(DragInfo dragInfo)
	{
		if (debug) Debug.Log("====MFDraggingEndHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
}
