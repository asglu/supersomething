using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Gesture.onDraggingStartE += DraggingStartHandler;
		Gesture.onDraggingE += DraggingHandler;
		Gesture.onDraggingEndE += DraggingEndHandler;
		Gesture.onMFDraggingStartE += MFDraggingStartHandler;
		Gesture.onMFDraggingE += MFDraggingHandler;
		Gesture.onMFDraggingEndE += MFDraggingEndHandler;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void DraggingStartHandler(DragInfo dragInfo)
	{
		Debug.Log("====DraggingStartHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	}
	
	void DraggingHandler(DragInfo dragInfo)
	{
		Debug.Log("====DraggingHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
		
	}
	
	void DraggingEndHandler(DragInfo dragInfo)
	{
		Debug.Log("====DraggingEndHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
	
	void MFDraggingStartHandler(DragInfo dragInfo)
	{
		Debug.Log("====MFDraggingStartHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
	
	void MFDraggingHandler(DragInfo dragInfo)
	{
		Debug.Log("====MFDraggingHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
	
	void MFDraggingEndHandler(DragInfo dragInfo)
	{
		Debug.Log("====MFDraggingEndHandler====\n|| fingercount: " + dragInfo.fingerCount +
										"\n|| index: " + dragInfo.index +
										"\n|| isFlick: " + dragInfo.isFlick +
										"\n|| pos: " + dragInfo.pos );
	
	}
}
