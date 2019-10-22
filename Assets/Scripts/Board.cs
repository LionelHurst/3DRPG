using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap floorTileMap;
    public Tilemap wallTileMap;

    public List<GameTile> floorTiles = new List<GameTile>();
    public List<GameObject> wallTiles = new List<GameObject>();

    public int mapWidth;
    public int mapHeight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Load(int width, int height)
    {
        mapWidth = width;
        mapHeight = height;

        _Load();

    }

    public void Load()
    {
        _Load();
    }

    private void _Load()
    {
        Debug.Log("Building map");

        for (int i = 0; i < mapWidth; i++)
        {

            for (int k = 0; k < mapHeight; k++)
            {
                floorTileMap.SetTile(new Vector3Int(i, k, 0), floorTiles[0]);
                //if (i == 0 || i == mapWidth-1)
                //Instantiate(wallTiles[0], floorTileMap.CellToWorld(new Vector3(i, k, 0)), Quaternion.identity).GetComponent<GameObject>();
            }
        }
    }
}
