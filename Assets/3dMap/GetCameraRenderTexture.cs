using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetCameraRenderTexture : MonoBehaviour {
    public Camera m_Camera;
    public RenderTexture renderTexture;
    public Material material;
    Texture2D texture2D ;


    // Use this for initialization
    void Awake () {

            texture2D = new Texture2D(m_Camera.targetTexture.width, m_Camera.targetTexture.height, TextureFormat.RGB24, false);




    }

    // Update is called once per frame
    void Update () {
        //RenderTexture.active = renderTexture ;

        //texture2D.ReadPixels(new Rect(0, 0, m_Camera.targetTexture.width, m_Camera.targetTexture.height), 0, 0);
        //System.IntPtr.

        //texture2D = Texture2D.CreateExternalTexture(m_Camera.targetTexture.width, m_Camera.targetTexture.height, TextureFormat.RGBA32, true, true, resourceView);

        //texture2D.Apply();
        //material.SetTexture("_ShadowTex", texture2D);




    }

}
