using System;
using System.Collections.Generic;
using sc.terrain.proceduralpainter;
using UnityEditorInternal;
using UnityEngine;

[CreateAssetMenu(fileName = "TerrainPainterPreset", menuName = "TerrainPainterPreset")]
public class TerrainPainterPreset : ScriptableObject
{
    public Dictionary<LayerSettings, ReorderableList> Settings;
}

[Serializable]
public struct TerrainPainterPresetData
{
    public TerrainLayer Layer;
}
