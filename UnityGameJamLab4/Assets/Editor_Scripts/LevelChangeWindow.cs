using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class LevelChangeWindow : EditorWindow 
{
    string[] scenes;
    string levelNameRuntime, levelNameEditor, newLevelName;
    string assetpull= "Assets/Scenes/";
    string endline =".unity";
    [MenuItem("Window/LevelChangerWindow")]
    public static void ShowWindow()
    {
        GetWindow<LevelChangeWindow>("Level Changer Window");
       
    }
    private void OnGUI()
    {
        GUILayout.Label("Runtime Scene Changer", EditorStyles.boldLabel);
        levelNameRuntime = EditorGUILayout.TextField("Scene Name Runtime", levelNameRuntime);
        if (GUILayout.Button("ChangeLevel"))
        { 
            SceneManager.LoadScene(levelNameRuntime);
        }


        GUILayout.Label("Editor Scene Changer", EditorStyles.boldLabel);
        levelNameEditor = EditorGUILayout.TextField("SceneName", levelNameEditor);
        if (GUILayout.Button("ChangeLevel"))
        {
            EditorSceneManager.OpenScene(assetpull+ levelNameEditor+ endline);
        }


        GUILayout.Label("Scene Creator", EditorStyles.boldLabel);
        newLevelName = EditorGUILayout.TextField("Name Level:", newLevelName);
        if (GUILayout.Button("Create!"))
        {
            Scene set= EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            set.name = newLevelName;
            EditorSceneManager.SaveOpenScenes();
        }

    }
}
