using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLandscapeButton : MonoBehaviour
{
    public void Save()
    {
#if UNITY_EDITOR
        string date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        var terrain = Terrain.activeTerrain;
        UnityEditor.AssetDatabase.CreateAsset(terrain.terrainData, $"Assets/SavedTerrainData-{date}.asset");
        UnityEditor.AssetDatabase.SaveAssets();
#endif
    }
}
