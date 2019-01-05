using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCG : MonoBehaviour {
    static ulong state= 0x4d595df4d0f33173;
    const ulong multipliers= 6364136223846793005UL;
    const ulong increment= 1442695040888963407UL;


    

    //public ulong seed;
    [HideInInspector]
    public uint output;

    // Use this for initialization

    public uint randomRotation(uint x, int y) {
        output = x >> y | x << (-y & 31);

        //Debug.Log(output);
        return output;
    }

    public uint PcgRandom32() {
        ulong x = state;
        ulong count = (ulong)(x >> 59);
        state = x * multipliers + increment;
        state = (state^(state >> 18))>>27;

        
        
        return randomRotation((uint)state,(int)count);
    }


    public void initPCG(ulong seed) {
        state = increment + seed;
        PcgRandom32();

    }


}
