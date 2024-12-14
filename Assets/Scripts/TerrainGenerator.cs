using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public event Action OnTerrainGenerated;
    
    [SerializeField] private TMP_InputField HeightInput;

    [SerializeField] private TMP_InputField WidthInput;

    [SerializeField] private TMP_InputField DepthInput;
    
    // Размеры ландшафта
    private int terrainWidth = 512;
    private int terrainHeight = 512;
    private int terrainDepth = 100;
    
    public void GenerateTerrain()
    {
        if (!int.TryParse(HeightInput.text, out terrainHeight) || 
            !int.TryParse(WidthInput.text, out terrainWidth) ||
            !int.TryParse(DepthInput.text, out terrainDepth)) return;
        
        // Создаем объект TerrainData
        TerrainData terrainData = new TerrainData();
        terrainData.heightmapResolution = CreatorWindow.Instance.HeightMap.width;

        // Устанавливаем размеры
        terrainData.size = new Vector3(terrainWidth, terrainDepth, terrainHeight);

        // Создаем массив высот
        float[,] heights = new float[CreatorWindow.Instance.HeightMap.width,
            CreatorWindow.Instance.HeightMap.height];

        // Заполняем массив высот на основе heightmap
        for (int x = 0; x < CreatorWindow.Instance.HeightMap.width; x++)
        {
            for (int y = 0; y < CreatorWindow.Instance.HeightMap.height; y++)
            {
                // Получаем значение яркости пикселя (0.0 - 1.0)
                float heightValue = CreatorWindow.Instance.HeightMap.GetPixel(x, y).grayscale;
                heights[x, y] = heightValue;
            }
        }

        // Устанавливаем высоты ландшафта
        terrainData.SetHeights(0, 0, heights);

        // Создаем объект Terrain
        GameObject terrainObj = Terrain.CreateTerrainGameObject(terrainData);
        terrainObj.transform.position = Vector3.zero;
        
        OnTerrainGenerated?.Invoke();
    }
}
