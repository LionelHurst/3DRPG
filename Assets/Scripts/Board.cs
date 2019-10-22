using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public List<GameObject> floorTiles = new List<GameObject>();
    public List<GameObject> wallTiles = new List<GameObject>();

    public Dictionary<Point, GameTile> tiles = new Dictionary<Point, GameTile>();

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

            for (int j = 0; j < mapHeight; j++)
            {
                GameObject instance = Instantiate(floorTiles[0]) as GameObject;
                GameTile gt = instance.GetComponent<GameTile>();
                gt.Load(new Point(i, j));
                tiles.Add(gt.pos, gt);
            }
        }
    }
}
