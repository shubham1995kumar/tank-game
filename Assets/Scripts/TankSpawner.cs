﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSwapner : MonoBehaviour
{
    [System.Serializable]

    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankTypes;
        public Material color;

    }
    public List<Tank> tankList;

    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void CreateTank(TankTypes tankType)
    {
        if(tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankTypes, tankList[0].color);
            TankController tankController = new TankController(tankModel, tankView);

        }
        else if (tankType == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankTypes, tankList[1].color);
            TankController tankController = new TankController(tankModel, tankView);

        }
        else if (tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankTypes, tankList[2].color);
            TankController tankController = new TankController(tankModel, tankView);

        }

    }

   
}
