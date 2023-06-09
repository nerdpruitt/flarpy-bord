using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueSet : MonoBehaviour
{
    public PipeSpawnScript spawner;
    public MountainSpawn background;
    public CloudSpawn cloudSpawner;
    public GameObject PipeEasy, PipeMed, PipeHard; //The three different speeds of pipe;
    public GameObject PipeMineEasy, PipeMineMed, PipeMineHard, EasyMine, MedMine, HardMine; //New additions
    public GameObject Bird; //The Player;
    public GameObject Menu, GoSign; //The Start Menu and Ready Message;
    public Color EasyColor, MediumColor, HardColor;
    bool begin = false;
    float beginWait = 2;

    //These scripts will be called with buttons on the start menu;
    public void Update()
    {
        if (begin == true)
        {
            beginWait -= Time.deltaTime;
            if (beginWait <= 0)
            {
                GoSign.SetActive(false);
                spawner.isOn = true;
                background.isOn = true;
                cloudSpawner.isOn = true;
                Bird.SetActive(true);
            }
        }       
    }
    public void Easy()
    {
        Menu.SetActive(false);
        spawner.pipe[0] = PipeEasy; //Speed 1;
        spawner.pipe[1] = PipeMineEasy;
        spawner.pipe[2] = EasyMine;
        spawner.spawnRate = 6; //The initial spawn rate;
        spawner.minPipeDistance = 3; //The minimum distance between pipes;
        spawner.decreaseTime = 0.1f; //The rate at which the pipes get closer together;
        Camera.main.backgroundColor = EasyColor; //Change background color;
        begin = true;
        GoSign.SetActive(true);
    }
    public void Meduim()
    {
        Menu.SetActive(false);
        spawner.pipe[0] = PipeMed; //Speed 2;
        spawner.pipe[1] = PipeMineMed;
        spawner.pipe[2] = MedMine;
        spawner.spawnRate = 5f; //The initial spawn rate;
        spawner.minPipeDistance = 2f; //The minimum distance between pipes;
        spawner.decreaseTime = 0.2f; //The rate at which the pipes get closer together;
        Camera.main.backgroundColor = MediumColor; //Change background color;
        begin = true;
        GoSign.SetActive(true);
    }
    public void Hard()
    {
        Menu.SetActive(false);
        spawner.pipe[0] = PipeHard; //Speed 3;
        spawner.pipe[1] = PipeMineHard;
        spawner.pipe[2] = HardMine;
        spawner.spawnRate = 4f; //The initial spawn rate;
        spawner.minPipeDistance = 1.5f; //The minimum distance between pipes;
        spawner.decreaseTime = 0.3f; //The rate at which the pipes get closer together;
        Camera.main.backgroundColor = HardColor; //Change background color;
        begin = true;
        GoSign.SetActive(true);
    }
}
