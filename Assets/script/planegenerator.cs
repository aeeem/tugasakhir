using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Mesh))]
public class planegenerator : MonoBehaviour {
    MeshFilter mf;

    public int xsize;
    public int ysize;

    Mesh plane;
    Vector3[] verticles;
	// Use this for initialization
	void Start () {

        verticles = new Vector3[(int)((xsize+1) *(1+ ysize))];
        mf = GetComponent<MeshFilter>();
        plane = new Mesh();
        mf.mesh = plane;






        for (int i = 0,y=0; y <= ysize; y++)
        {
            for (int x = 0; x <= xsize;x++, i++)
            {
                verticles[i] = new Vector3(x,0,y);
            }

        }
        plane.vertices = verticles;


        int[] tri = new int[(int)(xsize*ysize*6)];


        for (int ti = 0,vi=0,y=0; y < ysize; y++,vi++)
        {
            for (int x = 0; x < xsize; x++,ti+=6,vi++)
            {
                tri[ti] = vi;
                tri[ti + 3] = tri[ti + 2] = (int) (vi + 1);
                tri[ti + 4] = tri[ti + 1] = (int)(vi +xsize+ 1);
                tri[ti + 5] = (int)(vi + xsize + 2);
            }
        }
            plane.triangles = tri;
        //tri[0]= 0;
        //tri[1] = 2;
        //tri[2] = 1;
        //tri[3] = 2;
        //tri[4] = 3;
        //tri[5] = 1;

        //plane.triangles = tri;

        //Vector3[] normals = new Vector3[4];
        //normals[0] = -Vector3.forward;
        //normals[1] = -Vector3.forward;
        //normals[2] = -Vector3.forward;
        //normals[3] = -Vector3.forward;
        //plane.normals = normals;


        //Vector2[] uv = new Vector2[4];
        //uv[0] = new Vector2(0, 0);
        //uv[1] = new Vector2(1, 0);
        //uv[2] = new Vector2(0, 1);
        //uv[3] = new Vector2(1, 1);

        //plane.uv = uv;

    }


    private void OnDrawGizmos()
    {
        
        Gizmos.color = Color.blue;
        for (int i = 0; i < verticles.Length; i++)
        {
            Gizmos.DrawSphere(verticles[i],0.1f);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
