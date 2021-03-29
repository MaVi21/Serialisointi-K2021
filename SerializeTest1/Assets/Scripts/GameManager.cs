using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Cube cube;
    
    // Start is called before the first frame update
    void Start()
    {
        LoadCube();
    }

    private void LoadCube()
    {
        CubeInfo cubeInfo = SaveManager.LoadCube();
        Vector3 cubePosition = new Vector3();
        cubePosition.x = cubeInfo.position[0];
        cubePosition.y = cubeInfo.position[1];
        cubePosition.z = cubeInfo.position[2];
        GameObject.Find("Cube").transform.position = cubePosition;
    }

    public void OnSaveButtonClicked()
    {
        Debug.Log("Saving...");
        SaveManager.SaveCube(cube);
    }
}
