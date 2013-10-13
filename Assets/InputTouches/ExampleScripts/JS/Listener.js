#pragma strict

function Start () {
	
}

function OnEnable(){
	Gesture.onMultiTapE += OnTap;

	Gesture.onPinchE += OnPinch;
	Gesture.onDraggingStartE += OnDraggingStart;
	Gesture.onDraggingE += OnDragging;
}

function OnDisable(){
	Gesture.onMultiTapE += OnTap;

	Gesture.onPinchE -= OnPinch;
	Gesture.onDraggingStartE -= OnDraggingStart;
	Gesture.onDraggingE -= OnDragging;
}

function Update () {

}

function OnTap(tap:Tap){

}

function OnDragging(info:DragInfo){
	//info.pos - cursor pos
	//info.delta - move direction of the drag
	//info.fingerCount - how many finger is doing the drag
	//info.isMouse - is the drag being emulate by mouse
	
	//get previous screen pos
	var pos:Vector3=info.pos-info.delta;

	Debug.Log("user is dragging on screen from "+pos+" to "+info.pos);
}

function OnDraggingStart(info:DragInfo){
	//info.pos - cursor pos
	//info.delta - move direction of the drag
	//info.fingerCount - how many finger is doing the drag
	//info.isMouse - is the drag being emulate by mouse

	Debug.Log("A drag event with "+info.fingerCount+" finger(s) has been detected");
}

function OnPinch(pinfo:PinchInfo){
	//Debug.Log("Pinching, value: "+val);
}