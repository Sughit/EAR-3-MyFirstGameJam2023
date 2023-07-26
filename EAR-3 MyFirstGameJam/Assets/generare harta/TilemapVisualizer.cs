using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

public class TilemapVisualizer : MonoBehaviour
{
    [SerializeField]
    private Tilemap floorTilemap, wallTilemap;
    [SerializeField]
    private TileBase floorTile, wallTop, wallSideRight, wallSideLeft, wallBottom, wallFull,
        wallInnerCornerDownLeft, wallInnerCornerDownRight, 
        wallDiagonalCornerDownRight, wallDiagonalCornerDownLeft, wallDiagonalCornerUpRight, wallDiagonalCornerUpLeft;

    public Transform SpawnManager;

    public GameObject enemyPrefab;

    public GameObject playerPrefab;
    private Vector3 playerPos;
    public float playerSpawnArea;
    private bool canSpawnPlayer = true;

    //pentru usa care duce la nivelul urmator 

    public GameObject nextDoor;
    // public GameObject nextDoorLeft;
    // public GameObject nextDoorRight;
    private bool isDoor = true;

    public void PaintFloorTiles(IEnumerable<Vector2Int> floorPositions)
    {
        PaintTiles(floorPositions, floorTilemap, floorTile);
    }

    private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase tile)
    {
        foreach (var position in positions)
        {
            PaintSingleTile(tilemap, tile, position);
            //spawn player
            if (canSpawnPlayer)
            {
                playerPos = new Vector3(position.x + 0.5f, position.y + 0.5f, 0);
                Instantiate(playerPrefab, playerPos, Quaternion.identity, SpawnManager);
                canSpawnPlayer = false;
            }
            //spawn enemies
            if (Random.Range(0, 11) == 10 && Vector3.Distance(new Vector3(position.x + 0.5f, position.y + 0.5f, 0), playerPos) >= playerSpawnArea)
            {
                Instantiate(enemyPrefab, new Vector3(position.x + 0.5f, position.y + 0.5f, 0), Quaternion.identity, SpawnManager);
            }
        }
    }

    public void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
        {
            Destroy(oneObject);
        }
    }

    internal void PaintSingleBasicWall(Vector2Int position, string binaryType)
    {
        int typeAsInt = Convert.ToInt32(binaryType, 2);
        TileBase tile = null;
        if(WallTypesHelper.wallSideRight.Contains(typeAsInt))
        {
            tile = wallSideRight;
            // if(Random.Range(0,3) == 2 && isDoor && Vector3.Distance(new Vector3(position.x + 0.5f, position.y + 0.5f, 0), playerPos) >= 6 * playerSpawnArea)
            // {
            //     Instantiate(nextDoorRight, new Vector3(position.x + 0.5f, position.y + 0.5f, 0), Quaternion.identity, SpawnManager);
            //     isDoor = false;
            // }
        }
        else if (WallTypesHelper.wallSideLeft.Contains(typeAsInt))
        {
            tile = wallSideLeft;
            // if (Random.Range(0, 3) == 2 && isDoor && Vector3.Distance(new Vector3(position.x + 0.5f, position.y + 0.5f, 0), playerPos) >= 6 * playerSpawnArea)
            // {
            //     Instantiate(nextDoorLeft, new Vector3(position.x + 0.5f, position.y + 0.5f, 0), Quaternion.identity, SpawnManager);
            //     isDoor = false;
            // }
        }
        else if (WallTypesHelper.wallBottom.Contains(typeAsInt))
        {
            tile = wallBottom;
        }
        else if (WallTypesHelper.wallFull.Contains(typeAsInt))
        {
            tile = wallFull;
        }
        else if (WallTypesHelper.wallTop.Contains(typeAsInt))
        {
            tile = wallTop;
            if(isDoor && Vector3.Distance(new Vector3(position.x, position.y, 0), playerPos) >= 4 * playerSpawnArea)
            {
                Instantiate(nextDoor, new Vector3(position.x + 0.5f, position.y + 0.5f, 0), Quaternion.identity, SpawnManager);
                isDoor = false;
            }
        }

        if (tile != null)
            PaintSingleTile(wallTilemap, tile, position);
    }

    private void PaintSingleTile(Tilemap tilemap, TileBase tile, Vector2Int position)
    {
        var tilePosition = tilemap.WorldToCell((Vector3Int)position);
        tilemap.SetTile(tilePosition, tile);
    }

    public void Clear()
    {
        floorTilemap.ClearAllTiles();
        wallTilemap.ClearAllTiles();
        DestroyWithTag("Enemy");
        DestroyWithTag("Player");
        DestroyWithTag("Door");
        canSpawnPlayer = true;
        isDoor = true;
    }

    public void PaintSingleCornerWall(Vector2Int position, string binaryType)
    {
        int typeAsInt = Convert.ToInt32(binaryType, 2);
        TileBase tile = null;

        if(WallTypesHelper.wallInnerCornerDownLeft.Contains(typeAsInt))
        {
            tile = wallInnerCornerDownLeft;
        }
        else if (WallTypesHelper.wallInnerCornerDownRight.Contains(typeAsInt))
        {
            tile = wallInnerCornerDownRight;
        }
        else if (WallTypesHelper.wallDiagonalCornerDownLeft.Contains(typeAsInt))
        {
            tile = wallDiagonalCornerDownLeft;
        }
        else if (WallTypesHelper.wallDiagonalCornerDownRight.Contains(typeAsInt))
        {
            tile = wallDiagonalCornerDownRight;
        }
        else if (WallTypesHelper.wallDiagonalCornerUpRight.Contains(typeAsInt))
        {
            tile = wallDiagonalCornerUpRight;
        }
        else if (WallTypesHelper.wallDiagonalCornerUpLeft.Contains(typeAsInt))
        {
            tile = wallDiagonalCornerUpLeft;
        }
        else if (WallTypesHelper.wallFullEightDirections.Contains(typeAsInt))
        {
            tile = wallFull;
        }
        else if (WallTypesHelper.wallBottomEightDirections.Contains(typeAsInt))
        {
            tile = wallBottom;
        }

        if (tile != null)
            PaintSingleTile(wallTilemap, tile, position);
    }
}
