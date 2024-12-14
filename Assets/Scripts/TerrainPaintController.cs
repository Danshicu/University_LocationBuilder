using System.Collections;
using System.Collections.Generic;
using sc.terrain.proceduralpainter;
using UnityEngine;

public class TerrainPaintController : MonoBehaviour
{
    [SerializeField] public TerrainPainter painter;
    [SerializeField] public TerrainPainterPreset preset;
    
    // Start is called before the first frame update
    void Start()
    {
        //painter.layerSettings = preset.Settings.Keys;
    }

    [ContextMenu("CopySettings")]
    public void CopySettings()
    {
        //var settings = painter.GetComponent<TerrainPainterInspector>().m_modifierList;
        //preset.Settings = settings;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
}
