using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TerrainPainterPreset", menuName = "TerrainPainterPreset")]
public class TerrainPainterPreset : ScriptableObject
{
    private List<TerrainPainterPresetData> _painterDatas;
}

public struct TerrainPainterPresetData
{
    public TerrainLayer Layer;
}
