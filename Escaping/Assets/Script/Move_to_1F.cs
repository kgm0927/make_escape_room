using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_to_1F : Move_to_scene         // Kitchen ���� ������.
{
    // Start is called before the first frame update
    private new string scene_name = "1F";
 

    private void Awake()
    {
        base.scene_name = scene_name;
    }

    // Update is called once per frame
    public override void Move_the_Area(string name)
    {
        base.Move_the_Area(name);
        
    }
}
