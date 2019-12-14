using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class QuickTool : EditorWindow
{
    [MenuItem("Quickbar/Open _%#T")]
    public static void ShowWindow()
    {
        QuickTool tool = GetWindow<QuickTool>();

        tool.titleContent = new GUIContent("Quickbar");
        tool.minSize = new Vector2(256, 64);
    }

    private void OnEnable()
    {
        VisualElement root = rootVisualElement;

        root.styleSheets.Add(Resources.Load<StyleSheet>("Quick_Style"));

        VisualTreeAsset tree = Resources.Load<VisualTreeAsset>("Quick_Main");
        tree.CloneTree(root);

        UQueryBuilder<Button> buttons = root.Query<Button>();
        buttons.ForEach(SetupButton);
    }

    private void SetupButton(Button button)
    {
        VisualElement icon = button.Q(className: "quicktool-button-icon");
        Texture2D image;
        string path = "Icons/" + button.parent.name;
        if (image = Resources.Load<Texture2D>(path)){ }
        icon.style.backgroundImage = image;
        Label text = (Label)button.Q(className: "quicktool-button-label");
        text.text = button.parent.name;

        button.clickable.clicked += () => CreateObject(button.parent.name);
        button.tooltip = button.parent.name;
    }

    private void CreateObject(string type)
    {
        GameObject o;

        switch (type)
        {
            case "sphere":
                o = ObjectFactory.CreatePrimitive(PrimitiveType.Sphere);
                break;
            case "capsule":
                o = ObjectFactory.CreatePrimitive(PrimitiveType.Capsule);
                break;
            case "cylinder":
                o = ObjectFactory.CreatePrimitive(PrimitiveType.Cylinder);
                break;
            case "quad":
                o = ObjectFactory.CreatePrimitive(PrimitiveType.Quad);
                break;
            case "light":
                o = ObjectFactory.CreateGameObject("light", typeof(Light));
                break;
            case "object":
                o = ObjectFactory.CreateGameObject("object");
                break;
            case "Player1":
                Object fart = AssetDatabase.LoadAssetAtPath("Assets/GameObjects/Player1.prefab", typeof(GameObject));
                o = PrefabUtility.InstantiatePrefab(fart) as GameObject;
                break;
            case "Player2":
                Object fart2 = AssetDatabase.LoadAssetAtPath("Assets/GameObjects/Player2.prefab", typeof(GameObject));
                o = PrefabUtility.InstantiatePrefab(fart2) as GameObject;
                break;
            default:
                o = ObjectFactory.CreatePrimitive(PrimitiveType.Cube);
                break;
        }

        o.transform.position = Vector3.zero;
        Selection.activeGameObject = o;
    }
}
