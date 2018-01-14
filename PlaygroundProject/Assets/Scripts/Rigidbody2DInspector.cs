﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(Rigidbody2D))]
public class Rigidbody2DInspector : Editor
{
	public override void OnInspectorGUI()
	{
		serializedObject.Update();

		EditorGUILayout.PropertyField(serializedObject.FindProperty("m_BodyType"));

		GUILayout.Space(5f);
		EditorGUILayout.LabelField("Physical Properties", EditorStyles.boldLabel);
		EditorGUILayout.PropertyField(serializedObject.FindProperty("m_Mass"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("m_LinearDrag"), new GUIContent("Friction"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("m_AngularDrag"), new GUIContent("Angular Friction"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("m_GravityScale"), new GUIContent("Gravity"));
		
		
		GUILayout.Space(5f);
		bool constraintsGroup = true;
		constraintsGroup = EditorGUILayout.Foldout(constraintsGroup, new GUIContent("Constraints"));
		if(constraintsGroup)
		{
			if(Selection.gameObjects.Length == 1)
			{
				//retrieve checkbox values
				RigidbodyConstraints2D constraints = (RigidbodyConstraints2D)serializedObject.FindProperty("m_Constraints").intValue;
				RigidbodyConstraints2D oldConstraints = constraints;
				bool xConstraint = (constraints & RigidbodyConstraints2D.FreezePositionX) != 0;
				bool yConstraint = (constraints & RigidbodyConstraints2D.FreezePositionY) != 0;
				bool rotConstraint = (constraints & RigidbodyConstraints2D.FreezeRotation) != 0;

				//draw the checkboxes
				EditorGUI.indentLevel++;
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.PrefixLabel("Freeze Position");
				xConstraint = GUILayout.Toggle(xConstraint, "X", GUILayout.ExpandWidth(false));
				yConstraint = GUILayout.Toggle(yConstraint, "Y", GUILayout.ExpandWidth(false));
				EditorGUILayout.EndHorizontal();

				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.PrefixLabel("Freeze Rotation");
				rotConstraint = GUILayout.Toggle(rotConstraint, "Z");
				EditorGUILayout.EndHorizontal();
				EditorGUI.indentLevel--;

				//convert the booleans into a flag
				constraints = xConstraint ? RigidbodyConstraints2D.FreezePositionX : RigidbodyConstraints2D.None;
				if(yConstraint) constraints |= RigidbodyConstraints2D.FreezePositionY;
				if(rotConstraint) constraints |= RigidbodyConstraints2D.FreezeRotation;
				
				//write the property back
				if(oldConstraints != constraints)
				{
					serializedObject.FindProperty("m_Constraints").intValue = (int)constraints;
				}
			}
			else
			{
				EditorGUILayout.HelpBox("Select one GameObject at a time to modify constraints", MessageType.Warning);
			}
		}

		serializedObject.ApplyModifiedProperties();
	}
}