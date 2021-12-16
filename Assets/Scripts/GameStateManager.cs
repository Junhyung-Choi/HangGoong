using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStateManager
{
    
    public static bool[] roomList = {false,false,false};

    public static int isEnd()
    {
        int count = 0;
        for(int i = 0 ; i < 3; i++)
        {
            if (roomList[i]) count += 1;
        }
        return count;
    }
}
