using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CreateLandscapeButton : MonoBehaviour
{
    [SerializeField] private Button createLandscapeButton;
    [SerializeField] private TerrainPaintController paintController;
    [SerializeField] private TerrainGenerator terrainGenerator;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        terrainGenerator.OnTerrainGenerated += TerrainGeneratedCallback;
        createLandscapeButton.onClick.AddListener(() =>terrainGenerator.GenerateTerrain());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDisable()
    {
        terrainGenerator.OnTerrainGenerated -= TerrainGeneratedCallback;
        createLandscapeButton.onClick.RemoveListener(() =>terrainGenerator.GenerateTerrain());
    }

    private void TerrainGeneratedCallback()
    {
        paintController.painter.AssignActiveTerrains();
    }
}
