using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Adder))]
public class AdderEditor : Editor
{
	Adder adder;

	void OnEnable()
	{
		adder = (Adder)target;
	}

	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		EditorGUILayout.Space();

		GUIStyle style = new GUIStyle(EditorStyles.boldLabel);
		style.normal.textColor = Color.cyan;

		EditorGUILayout.LabelField(
			string.Format ("{0} + {1} = {2}",
				adder.a, adder.b, adder.a + adder.b),
			style
		);

		EditorGUILayout.Space();
	}
}
