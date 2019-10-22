using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameTile : Tile
{
    [SerializeField]
    public int cost;

    public int GetCost()
    {
        return cost;
    }

    #if UNITY_EDITOR
    [MenuItem("Assets/Create/GameTile")]
    public static void CreateGameTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save Game Tile", "New Game Tile", "asset", "Save Game Tile", "Assets");
        if (path == "")
            return;

        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<GameTile>(), path);
    }
    #endif

}
