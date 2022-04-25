using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AllLevelsObject))]

public class AllLevelsEditor : Editor
{
    AllLevelsObject levelObject;

    private void Awake()
    {
        levelObject = (AllLevelsObject)target;
    }

    void MyGUI()
    {
        if(GUILayout.Button("Add Level"))
        {
            levelObject.AddLevel();
        }

        for(int i = 0; i < levelObject.levels.Count; i++)
        {
            //levelObject.levels[i].levelNumber = EditorGUILayout.IntField("Level #", levelObject.levels[i].levelNumber);
            EditorGUILayout.LabelField(levelObject.levels[i].levelNumber.ToString());
            levelObject.levels[i].levelName = EditorGUILayout.TextField("Name", levelObject.levels[i].levelName);
            EditorGUILayout.Space();
            EditorGUILayout.Space();

        }
    }

    public override void OnInspectorGUI()
    {
        MyGUI();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        DrawDefaultInspector();
    }
}
