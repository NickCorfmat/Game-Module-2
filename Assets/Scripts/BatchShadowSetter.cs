using UnityEditor;
using UnityEngine;

// code from ChatGPT

public class BatchShadowSetter: EditorWindow {
    private LightShadows shadowType = LightShadows.Soft; // Default to Soft Shadows

    [MenuItem("Tools/Batch Shadow Setter")]
    public static void ShowWindow() {
        GetWindow<BatchShadowSetter>("Batch Shadow Setter");
    }

    void OnGUI() {
        GUILayout.Label("Set Shadows for All Lights", EditorStyles.boldLabel);

        // Dropdown for shadow type
        shadowType = (LightShadows) EditorGUILayout.EnumPopup("Shadow Type", shadowType);

        if (GUILayout.Button("Apply To All Lights")) {
            ApplyShadowsToAllLights();
        }
    }

    private void ApplyShadowsToAllLights() {
        // Find all lights in the current scene
        Light[] sceneLights = FindObjectsOfType<Light>();

        // Change shadow settings for each light
        foreach (Light light in sceneLights) {
            Undo.RecordObject(light, "Set Shadow");
            light.shadows = shadowType;
            EditorUtility.SetDirty(light); // Mark the light as dirty so changes are saved
        }

        Debug.Log($"Shadows set to {shadowType} for {sceneLights.Length} lights.");
    }
}