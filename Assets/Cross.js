#pragma strict

function Start () {
    var centeredStyle = GUI.skin.GetStyle("Label");
    centeredStyle.alignment = TextAnchor.UpperCenter;
    GUI.Label (Rect (Screen.width/2-12.5, Screen.height/2-12.5, 25, 25), "+", centeredStyle);
}