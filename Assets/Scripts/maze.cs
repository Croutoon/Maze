using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maze : MonoBehaviour
{
    public GameObject Wall;
    public int[,] grid = new int[13,13];

    void Start()
    {
        

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            grid[i, 0] = 1;
            grid[i, 12] = 1;
        }
        for (int i = 0; i < grid.GetLength(1); i++)
        {
            grid[0, i] = 1;
            grid[12, i] = 1;
        }

        grid[6, 0] = 0;
        grid[0, 8] = 0;
        grid[4, 1] = 1;
        grid[4, 2] = 1;
        grid[2, 2] = 1;
        grid[2, 3] = 1;
        grid[2, 4] = 1;
        grid[3, 4] = 1;
        grid[4, 4] = 1;
        grid[4, 5] = 1;
        grid[5, 5] = 1;
        grid[6, 2] = 1;
        grid[7, 2] = 1;
        grid[8, 2] = 1;
        grid[8, 4] = 1;
        grid[9, 4] = 1;
        grid[10, 2] = 1;
        grid[10, 3] = 1;
        grid[10, 4] = 1;
        grid[10, 5] = 1;
        grid[11, 5] = 1;
        grid[6, 3] = 1;
        grid[6, 4] = 1;
        grid[6, 5] = 1;
        grid[6, 6] = 1;
        grid[4, 6] = 1;
        grid[4, 7] = 1;
        grid[4, 8] = 1;
        grid[4, 9] = 1;
        grid[4, 11] = 1;
        grid[3, 8] = 1;
        grid[2, 8] = 1;
        grid[2, 6] = 1;
        grid[1, 7] = 1;
        grid[2, 7] = 1;
        grid[2, 8] = 1;
        grid[2, 9] = 1;
        grid[2, 10] = 1;
        grid[5, 8] = 1;
        grid[6, 8] = 1;
        grid[7, 8] = 1;
        grid[8, 8] = 1;
        grid[8, 7] = 1;
        grid[9, 7] = 1;
        grid[10, 7] = 1;
        grid[8, 6] = 1;
        grid[6, 9] = 1;
        grid[6, 10] = 1;
        grid[7, 10] = 1;
        grid[8, 10] = 1;
        grid[9, 10] = 1;
        grid[10, 10] = 1;
        grid[10, 9] = 1;


        for (int x = 0;x < grid.GetLength(0); x++)
        {
            for(int y = 0;y < grid.GetLength(1); y++)
            {
                switch (grid[x, y])
                {
                    case 0:

                        break;
                    case 1:
                        Instantiate(Wall, new Vector3(x, y, 0f), Quaternion.Euler(0,0,0));
                        break;

                    default: break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
