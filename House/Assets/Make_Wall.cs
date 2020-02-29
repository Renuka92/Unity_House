using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make_Wall : MonoBehaviour
{
    public GameObject wall;


    // Start is called before the first frame update

    void Start()
    {

        //LEFT WALL
        for (int LW_Y = 0; LW_Y < 20; LW_Y++)
        {
            for (int LW_X = 0; LW_X < 20; LW_X++)
            {
                Instantiate(wall, new Vector3(LW_X, LW_Y, 0), Quaternion.identity);
            }
        }

        //RIGHT WALL
        for (int RW_Y = 0; RW_Y < 20; RW_Y++)
        {
            for (int RW_X = 0; RW_X < 20; RW_X++)
            {
                Instantiate(wall, new Vector3(RW_X, RW_Y, 20), Quaternion.identity);
            }
        }

        //BACK WALL
        for (int BW_Z = 0; BW_Z < 20; BW_Z++)
        {
            for (int BW_Y = 0; BW_Y < 20; BW_Y++)
            {
                Instantiate(wall, new Vector3(0, BW_Y, BW_Z), Quaternion.identity);
            }
        }

        //FRONT WALL
        for (int FW_Z = 0; FW_Z < 20; FW_Z++)
        {
            for (int FW_Y = 0; FW_Y < 20; FW_Y++)
            {
                Instantiate(wall, new Vector3(19, FW_Y, FW_Z), Quaternion.identity);
            }
        }

        //FLOOR
        for (int j = 0; j < 20; j++)
        {
            for (int i = 0; i < 19; i++)
            {
                Instantiate(wall, new Vector3(i, 0, j), Quaternion.identity);
            }
        }

        //ROOF
        for (int r = 25; r > -6; r--)
        {
            for (int q = 0; q < 20; q++)
            {
                Instantiate(wall, new Vector3(q, 20, r), Quaternion.identity);
            }
        }
    }
}