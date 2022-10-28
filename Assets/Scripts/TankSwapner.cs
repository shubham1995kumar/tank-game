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
        CreateTank();
    }
    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankTypes, tankList[0].color);
        TankController tankController = new TankController(tankModel,tankView);

    }


}
