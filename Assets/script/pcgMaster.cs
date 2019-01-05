using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcgMaster : MonoBehaviour {

    public ulong something;
    PCG number;
    public uint[] range= new uint[2];
    
    


    ulong oldsomething;
    // Use this for initialization
    void Start() {
        number = GetComponent<PCG>();
    }
    public int generateNumber()
    {
        oldsomething = something;
        number.initPCG(oldsomething);
        something = number.output;
        return (int)something;
    }
    public int generateNumber(int r1, int r2) {

        uint Max =unchecked((uint) (r2 - r1));
        uint treshold = (uint)(-Max) % Max;
        while (true)
        {


            uint y = (uint)generateNumber();

            if (y>=treshold)
            {
            return (int)(unchecked((y % Max) + r1));

            }

        }
     }
    
    // Update is called once per frame
    void Update() {

        //x = generateNumber(int) range[0] , (int)range[1]);


        Debug.Log(generateNumber(-10,10));






    }
}