using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SpriteAssigner))]
public class SpriteAssignerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SpriteAssigner script = (SpriteAssigner)target;

        GUILayout.Space(10);
        GUILayout.Label("Atribuição de Sprite", EditorStyles.boldLabel);

        if (GUILayout.Button("🎲 Atribuir Sprite Aleatório"))
        {
            AssignRandomSprite(script);
        }

        GUILayout.Space(5);
        if (script.sprites != null && script.sprites.Length > 0)
        {
            for (int i = 0; i < script.sprites.Length; i++)
            {
                Sprite sprite = script.sprites[i];
                string spriteName = sprite != null ? sprite.name : "(null)";
                if (GUILayout.Button($"[{i}] {spriteName}"))
                {
                    AssignSprite(script, i);
                }
            }
        }
        else
        {
            EditorGUILayout.HelpBox("Adicione sprites ao array para usar os botões.", MessageType.Info);
        }
    }

    private void AssignRandomSprite(SpriteAssigner script)
    {
        if (script.sprites.Length == 0) return;

        int randomIndex = Random.Range(0, script.sprites.Length);
        AssignSprite(script, randomIndex);
    }

    private void AssignSprite(SpriteAssigner script, int index)
    {
        SpriteRenderer spriteRenderer = script.GetComponent<SpriteRenderer>();

        if (spriteRenderer != null && script.sprites[index] != null)
        {
            Undo.RecordObject(spriteRenderer, "Atribuir Sprite");
            spriteRenderer.sprite = script.sprites[index];
            EditorUtility.SetDirty(spriteRenderer);
        }
    }
}
